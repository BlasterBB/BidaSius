//----------------------------------------------------------------------------
//  Copyright (C) 2004-2016 by EMGU Corporation. All rights reserved.       
//----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Linq;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using BidaSius;
using Emgu.CV.Cuda;
using Stream = System.IO.Stream;

namespace tarcza
{
    public partial class CameraCapture : Form
    {
        #region props

        public Form MainF { get; set; }
        private Capture _capture = null;
        private bool _captureInProgress;
        delegate void SkonczonyPrzepierdalanie(ProcessFrameResult result);
        public int threshhhhh { get; set; }
        private TargetDetails _useThisTarget = new TargetDetails();
        public TargetDetails useThisTarget { get { return _useThisTarget; } set { _useThisTarget = value; } }
        bool captureRectFlag = false;
        public int pauseTimer = 0;
        public bool useManualShotPositiong = false;
        public bool alreadyManual = false;
        image nw = new image();
        public BidaSiusState CurrentState { get; set; }

        #endregion








        Timer My_Timer = new Timer();
        int FPS = 30;

















        #region public 

        public CameraCapture()
        {
            InitializeComponent();
            CvInvoke.UseOpenCL = false;
            ReadSettings();
            FillComPorts();
            My_Timer.Interval = 5000 ;
            My_Timer.Tick += new EventHandler((sender, args) => {System.GC.Collect(); });
            My_Timer.Start();

        }

        #endregion

        #region private

        private void ProcessFrame(object sender, EventArgs arg)
        {
            Mat frame = new Mat();
            using (frame)
            {
                _capture.Retrieve(frame);



                //   imageBox4.Image = frame;//preview

                int threshOne = 0;
                int threstwo = 0;
                int threshone1 = 0;
                int threshtwo1 = 0;


                if (this.trackThreshOne.InvokeRequired)
                {
                    threshOne = (int)this.Invoke(new Func<int>(() => trackThreshOne.Value));
                    threstwo = (int)this.Invoke(new Func<int>(() => trackthreshTwo.Value));
                    threshone1 = (int)this.Invoke(new Func<int>(() => trackthresh3.Value));
                    threshtwo1 = (int)this.Invoke(new Func<int>(() => trackthresh4.Value));

                }
                else
                {
                    threshOne = trackThreshOne.Value;
                    threstwo = trackthreshTwo.Value;
                    threshone1 = trackthresh3.Value;
                    threshtwo1 = trackthresh4.Value;
                }

                ProcessFrameResult result;
                if (!useManualShotPositiong)
                {
                    AditionaCapturelData acd = new AditionaCapturelData()
                    {
                        Frame = frame,
                        CurrentState = CurrentState,
                        FirstCannyThresh = threshOne,
                        secondCannyThresh = threstwo,
                        firstCannyThresh1 = threshone1,
                        secondCannyThresh1 = threshtwo1,
                        MainTargetDetails = useThisTarget
                    };
                    result = CaptureHelper.ProcessFrame(acd);
                    //UstawRezultat(result);
                    //result.Dispose();

                }
                else if (useManualShotPositiong && !alreadyManual)
                {
                    alreadyManual = true;
                    result = CaptureHelper.ManualProcessFrame(frame, threshOne, threstwo, threshone1, threshtwo1, useThisTarget);
                }
                else
                    return;

                UstawRezultat(result);
            }
        }

        private void ProcessFromFile()
        {
            Mat frame = new Mat();

            //Load the image from file and resize it for display
            Image<Bgr, Byte> ff = new Image<Bgr, byte>(fileNameTextBox.Text);//.Resize(400, 400, Emgu.CV.CvEnum.Inter.Linear, true);
            frame = ff.Mat;


            int threshOne = 0;
            int threstwo = 0;
            int threshone1 = 0;
            int threshtwo1 = 0;



            if (this.trackThreshOne.InvokeRequired)
            {
                threshOne = (int)this.Invoke(new Func<int>(() => trackThreshOne.Value));
                threstwo = (int)this.Invoke(new Func<int>(() => trackthreshTwo.Value));
                threshone1 = (int)this.Invoke(new Func<int>(() => trackthresh3.Value));
                threshtwo1 = (int)this.Invoke(new Func<int>(() => trackthresh4.Value));
            }
            else
            {
                threshOne = trackThreshOne.Value;
                threstwo = trackthreshTwo.Value;
                threshone1 = trackthresh3.Value;
                threshtwo1 = trackthresh4.Value;
            }




            var result = CaptureHelper.ProcessFromFile(frame, threshOne, threstwo, threshone1, threshtwo1, useThisTarget);
            UstawRezultat(result);
            //imageBox1.Image = result.TargetScanWithResult;
            //  imageBox2.Image = result.TargetMarked;

            //  imageBox3.Image = result.GrSmootWarped;


            //  imageBox4.Image = result.SmOryCanny;
            //imageBox1.Image = result.TargetMarked;

        }

        private void ScrollPaper()
        {
            if (comboComPorts.Items.Count == 0)
                return;

            System.IO.Ports.SerialPort myPort = new System.IO.Ports.SerialPort(comboComPorts.SelectedValue.ToString(), 9600);
            if (myPort.IsOpen == false) //if not open, open the port
                myPort.Open();
            myPort.Write("on");
            myPort.Close();
        }

        private void GetTargetRect()
        {
            TargetDetails td = new TargetDetails();
            td.TL = new Point((int)textBoxTLX.Value, (int)textBoxTL.Value);
            td.TR = new Point((int)textBoxTRX.Value, (int)textBoxTR.Value);
            td.BR = new Point((int)textBoxBRX.Value, (int)textBoxBR.Value);
            td.BL = new Point((int)textBoxBLX.Value, (int)textBoxBL.Value);

            td.TargetRect = new PointF[] {
                td.TL,
                td.TR,
                td.BR,
                td.BL
            };

            td.BlackR = (int)numBLCKradius.Value;
            td.BlackCenter = new Point((int)numBLCx.Value, (int)numBLCy.Value);
            useThisTarget = td;


            SaveSettings(td);
        }

        private static void SaveSettings(TargetDetails td)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("AppSettings.bin",
                FileMode.OpenOrCreate,
                FileAccess.Write, FileShare.Read);
            formatter.Serialize(stream, td);
            stream.Close();
        }

        private void FillComPorts()
        {

            List<String> allPorts = new List<String>();
            foreach (String portName in System.IO.Ports.SerialPort.GetPortNames())
            {
                allPorts.Add(portName);
            }
            comboComPorts.DataSource = allPorts;

        }

        private void ReadSettings()
        {
            TargetDetails td = new TargetDetails();
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("AppSettings.bin",
                                      FileMode.OpenOrCreate,
                                      FileAccess.Read,
                                      FileShare.Read);
            if (stream.Length == 0)
            {
                td.BL = new Point(283, 671);
                td.BR = new Point(1038, 675);
                td.TL = new Point(350, 28);
                td.TR = new Point(975, 39);
                td.BlackCenter = new Point(374, 374);
                td.BlackR = 133;
                td.TargetRect = new PointF[4];
                td.TargetRect[0] = new PointF(350, 28);
                td.TargetRect[1] = new PointF(975, 39);
                td.TargetRect[2] = new PointF(1038, 675);
                td.TargetRect[3] = new PointF(283, 671);

            }
            else
            {
                td = (TargetDetails)formatter.Deserialize(stream);
            }
            stream.Close();
            SaveSettings(td);
            useThisTarget = td;
            FillSettingsToGui(td);

        }

        private void FillSettingsToGui(TargetDetails td)
        {
            textBoxTLX.Value = td.TL.X;
            textBoxTL.Value = td.TL.Y;

            textBoxTRX.Value = td.TR.X;
            textBoxTR.Value = td.TR.Y;

            textBoxBRX.Value = td.BR.X;
            textBoxBR.Value = td.BR.Y;

            textBoxBLX.Value = td.BL.X;
            textBoxBL.Value = td.BL.Y;

            numBLCKradius.Value = (int)td.BlackR;
            numBLCx.Value = td.BlackCenter.X;
            numBLCy.Value = td.BlackCenter.Y;
        }

        private void InitCamera()
        {
            try
            {
                _capture = new Capture((int)numericCameraNo.Value);

                // _capture.SetCaptureProperty(CapProp.FrameHeight, 768);
                //_capture.SetCaptureProperty(CapProp.FrameWidth, 1024);

                _capture.SetCaptureProperty(CapProp.FrameHeight, 1080);
                _capture.SetCaptureProperty(CapProp.FrameWidth, 1920);

                _capture.ImageGrabbed += ProcessFrame;

                // LeftCameraImageCapture = new Capture(CaptureType.DShow);

                //// Get Frames from Left Camera...
                //var mm = LeftCameraImageCapture.QueryFrame();

                //// Set the Resolution of the Camera...
                //LeftCameraImageCapture.SetCaptureProperty(CapProp.FrameWidth, 1024);
                //LeftCameraImageCapture.SetCaptureProperty(CapProp.FrameHeight, 768);

                //// Initialize the Left Camera Frame Capture Timer...
                //Application.Idle += new EventHandler(ProcessFrame);
                // var mm = LeftCameraImageCapture.QueryFrame();
                Ustawienia = true;
                //   CurrentState = BidaSiusState.SetTargetBoundries;

            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }

        public bool Ustawienia { get; set; }
        private Mat blbal;
        private void UstawRezultat(ProcessFrameResult result)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.label10.InvokeRequired)
            {
                SkonczonyPrzepierdalanie d = new SkonczonyPrzepierdalanie(UstawRezultat);
                this.Invoke(d, new object[] { result });
            }
            else
            {
                if (captureRectFlag)
                {
                    FillSettingsToGui(result.Target);
                }

                //captureImageBox.Image = result.Oryginal;
                //grayscaleImageBox.Image = result.SmoothedOryginal;
                //cannyImageBox.Image = result.SmOryCanny;
                //smoothedGrayscaleImageBox.Image = result.FoundKontur;
                // testPB.Image = result.TargetMarked.ToImage<>()

                switch (CurrentState)
                {
                    case BidaSiusState.Start:
                        break;
                    case BidaSiusState.SetTargetBoundries:
                        using (Mat mm = result.TargetMarked.Clone())
                        {
                            nw.setImage(mm.Bitmap);
                        }
                        break;
                    case BidaSiusState.SetTargetSizeNPosition:

                        using (result.Warped)
                        {
                            using (Mat mm1 = result.Warped.Clone())
                            {
                                nw.setImage(mm1.Bitmap);
                            }
                        }
                        break;
                    case BidaSiusState.Play:
                       
                        if (MainF == null)
                            MainF = new MainForm();

                        MainForm mf = (MainForm)MainF;
                        if (!mf.IsAccessible)
                            mf.Show();

                        if (mf != null && result.Shot != null)
                        {
                            var lastshot = mf.Shots.LastOrDefault();
                            alreadyManual = false;
                            useManualShotPositiong = false;
                            buttonPauseAndSelect.Enabled = true;
                            if (lastshot != null && (result.Shot.Time - lastshot.Time) < (TimeSpan.TicksPerSecond * 4))
                                return;
                            mf.Shots.Add(result.Shot);
                            result.TargetScanWithResult?.Save("C:\\Users\\mjordanek\\Desktop\\imagesSius\\" + DateTime.Now.Ticks.ToString() + ".jpg");
                            result.Warped?.Save("C:\\Users\\mjordanek\\Desktop\\imagesSius\\" + DateTime.Now.Ticks.ToString() + "_oryg.jpg");
                            //MessageBox.Show("zarejestrowane " + result.shot.Value.ToString());
                            //  DialogResult result1 = MessageBox.Show("zarejestrowane " + result.shot.Value.ToString(), "czekaj", MessageBoxButtons.YesNo);
                            ScrollPaper();
                            mf.RefreshTarget();

                            if (result.TargetScanWithResult != null)
                            {
                                using (Mat mm = result.TargetScanWithResult.Clone())
                                {
                                    nw.setImage(mm.Bitmap);
                                }
                            }

                        }

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }



                //Mat mm1 = new Mat();
                //using (mm1= result.TargetScanWithResult.Clone())
                //{
                //    imageBox4.Image = mm1;

                //    imageBox4.Refresh();
                //}



                // imageBox1.SetZoomScale(0.4, new Point(0,0));
                // sd = result.TargetMarked.Clone().Bitmap;
                // sd = result.TargetMarked.Clone().Bitmap;




                // imageBox1.Refresh();
                //      result.TargetMarked.Dispose();
                //   imageBox2.Image = result.Warped;
                //   imageBox3.Image = result.WarpedTargetCanny;
                if (Ustawienia)
                {
                    //blbal = result.TargetMarked.Clone();
                    // imageBox1.Image = blbal;

                    //imageBox4.Image = result.TargetScanWithResult.Clone();

                    //System.GC.Collect();
                }
                //  result.TargetMarked.Dispose();
                //result.TargetScanWithResult?.Dispose();



            }
        }

        private void ReleaseData()
        {
            _capture?.Dispose();
        }

        #endregion

        #region events
        private void CaptureButtonClick(object sender, EventArgs e)
        {
            if (_capture == null)
                InitCamera();


            switch (CurrentState)
            {
                case BidaSiusState.Start:
                    nw.Show();
                    captureButton.Text = "Dalej";
                    _capture.Start();
                    CurrentState = BidaSiusState.SetTargetBoundries;
                    break;

                case BidaSiusState.SetTargetBoundries:
                    captureButton.Text = "Rozpocznij";
                    CurrentState = BidaSiusState.SetTargetSizeNPosition;
                    break;
                case BidaSiusState.SetTargetSizeNPosition:
                    //nw.Close();
                    captureButton.Text = "Stop";
                    CurrentState = BidaSiusState.Play;
                    break;
                case BidaSiusState.Play:
                    captureButton.Text = "Start Capture";
                    _capture.Pause();
                    _capture.Stop();
                    _capture.Dispose();
                    _capture = null;
                    nw.Hide();
                    CurrentState = BidaSiusState.Start;
                    break;
            }
            //start the capture
            // captureButton.Text = "Stop";
            //_capture.Start();
            //  My_Timer.Interval = 1000 / FPS;
            // My_Timer.Tick += new EventHandler(ProcessFrame);
            //  My_Timer.Start();

            // }

            // _captureInProgress = !_captureInProgress;

        }

        private void trackThreshOne_ValueChanged(object sender, EventArgs e)
        {
            label12.Text = trackThreshOne.Value.ToString();
            threshhhhh = trackThreshOne.Value;
            //   ProcessFrame(null, null);
        }

        private void trackthreshTwo_ValueChanged(object sender, EventArgs e)
        {
            label11.Text = trackthreshTwo.Value.ToString();
            //   ProcessFrame(null, null);
        }

        private void trackthresh4_ValueChanged(object sender, EventArgs e)
        {
            label10.Text = trackthresh4.Value.ToString();
            //     ProcessFrame(null, null);
        }

        private void trackthresh3_ValueChanged(object sender, EventArgs e)
        {
            label9.Text = trackthresh3.Value.ToString();
            //     ProcessFrame(null, null);
        }

        private void textBoxTLX_ValueChanged(object sender, EventArgs e)
        {
            GetTargetRect();
        }

        private void buttonTestCom_Click(object sender, EventArgs e)
        {
            ScrollPaper();

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void loadImageButton_Click_1(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                fileNameTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void fileNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ProcessFromFile();
        }

        #endregion

        private void buttonPauseAndSelect_Click_1(object sender, EventArgs e)
        {
            useManualShotPositiong = true;
            buttonPauseAndSelect.Enabled = false;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void CameraCapture_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReleaseData();
        }
    }



}
