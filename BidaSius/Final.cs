using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BidaSius
{
    public partial class Final : Form
    {
        public List<Shot> Shots = new List<Shot>();
        private TargetDetails bidaSiusSettings;
        int strzNaSerie = 5;

        int hours = 0;
        int minutes = 0;
        int seconds = 0;

        public Final(TargetDetails settings)
        {
            InitializeComponent();
            bidaSiusSettings = settings;
            Shots.Add(new Shot { No = 1, Value = 10.9, Time = DateTime.Now.Ticks, PointFromCenter = new Point { X = 5, Y = 5 } });
            Shots.Add(new Shot { No = 1, Value = 10.5, Time = DateTime.Now.Ticks + 1, PointFromCenter = new Point { X = 15, Y = 15 } });
            Shots.Add(new Shot { No = 1, Value = 9.9, Time = DateTime.Now.Ticks + 2, PointFromCenter = new Point { X = 21, Y = 35 } });
            Shots.Add(new Shot { No = 1, Value = 8.9, Time = DateTime.Now.Ticks + 3, PointFromCenter = new Point { X = 28, Y = 35 } });
            Shots.Add(new Shot { No = 1, Value = 10.1, Time = DateTime.Now.Ticks + 4, PointFromCenter = new Point { X = 27, Y = 25 } });
            Shots.Add(new Shot { No = 1, Value = 10.2, Time = DateTime.Now.Ticks + 5, PointFromCenter = new Point { X = 22, Y = 23 } });
            Shots.Add(new Shot { No = 1, Value = 10.4, Time = DateTime.Now.Ticks + 6, PointFromCenter = new Point { X = 34, Y = 11 } });
            Shots.Add(new Shot { No = 1, Value = 10.2, Time = DateTime.Now.Ticks + 7, PointFromCenter = new Point { X = 45, Y = 66 } });
            Shots.Add(new Shot { No = 1, Value = 7, Time = DateTime.Now.Ticks + 8, PointFromCenter = new Point { X = 21, Y = 34 } });
            Shots.Add(new Shot { No = 1, Value = 8, Time = DateTime.Now.Ticks + 9, PointFromCenter = new Point { X = 20, Y = 55 } });
            Shots.Add(new Shot { No = 1, Value = 9.7, Time = DateTime.Now.Ticks + 10, PointFromCenter = new Point { X = 10, Y = 32 } });

            Shots.Add(new Shot { No = 1, Value = 10.5, Time = DateTime.Now.Ticks + 11, PointFromCenter = new Point { X = 15, Y = 15 } });
            Shots.Add(new Shot { No = 1, Value = 9.9, Time = DateTime.Now.Ticks + 21, PointFromCenter = new Point { X = 21, Y = 35 } });
            Shots.Add(new Shot { No = 1, Value = 8.9, Time = DateTime.Now.Ticks + 32, PointFromCenter = new Point { X = 28, Y = 35 } });
            Shots.Add(new Shot { No = 1, Value = 10.1, Time = DateTime.Now.Ticks + 34, PointFromCenter = new Point { X = 27, Y = 25 } });
            Shots.Add(new Shot { No = 1, Value = 10.2, Time = DateTime.Now.Ticks + 45, PointFromCenter = new Point { X = 22, Y = 23 } });
            Shots.Add(new Shot { No = 1, Value = 10.4, Time = DateTime.Now.Ticks + 56, PointFromCenter = new Point { X = 34, Y = 11 } });
            Shots.Add(new Shot { No = 1, Value = 10.2, Time = DateTime.Now.Ticks + 67, PointFromCenter = new Point { X = 45, Y = 66 } });
            Shots.Add(new Shot { No = 1, Value = 7, Time = DateTime.Now.Ticks + 58, PointFromCenter = new Point { X = 21, Y = 34 } });
            Shots.Add(new Shot { No = 1, Value = 8, Time = DateTime.Now.Ticks + 95, PointFromCenter = new Point { X = 20, Y = 55 } });
            Shots.Add(new Shot { No = 1, Value = 9.7, Time = DateTime.Now.Ticks + 510, PointFromCenter = new Point { X = 10, Y = 32 } });

            Shots.Add(new Shot { No = 1, Value = 10.5, Time = DateTime.Now.Ticks + 61, PointFromCenter = new Point { X = 15, Y = 15 } });
            Shots.Add(new Shot { No = 1, Value = 9.9, Time = DateTime.Now.Ticks + 27, PointFromCenter = new Point { X = 21, Y = 35 } });
            Shots.Add(new Shot { No = 1, Value = 8.9, Time = DateTime.Now.Ticks + 38, PointFromCenter = new Point { X = 28, Y = 35 } });
            
            //   flPanelSeries.Controls.Add(new testUC());


            RefreshTarget();
        }

        public void RefreshTarget()
        {
            DrawAllTarget();
            var sum = Shots.Sum(a => a.SingleValue);
            var sumP = Shots.Sum(a => a.Value);
            var sumTxt = sumP.ToString("F1") + " (" + sum.ToString() + ") ";
            labelSum.Text = sumTxt;

            AddSeriesRows();
            if (flPanelSeries.Controls.Count > 0)
                flPanelSeries.ScrollControlIntoView(flPanelSeries.Controls[flPanelSeries.Controls.Count - 1]);
        }

        private void DrawAllTarget()
        {
            TargetIB.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.PanAndZoom;
            if (true)
                TargetIB.Image = TargetDrawHelper.DrawTarget(Shots);
            else
            {
                var sss = (Shots.Count() / strzNaSerie) * strzNaSerie;
                var skip = sss;
                if (Shots.Count() % strzNaSerie == 0)
                    skip = sss - strzNaSerie;

                var serie = Shots.Skip(Math.Max(0, skip)).ToList();
                TargetIB.Image = TargetDrawHelper.DrawTarget(serie);
            }
            TargetIB.HideScrolls = false;
        }

        private void AddSeriesRows()
        {
          
            labSeries.Text = string.Empty;

            strzNaSerie = 5;
            int skip = 5;



            for (int i = 0; i < 3; i++)
            {
                if (i == 2)
                {
                    strzNaSerie = 14;
                }

                var serie = Shots.Skip(i * skip).Take(strzNaSerie).ToList();
                serie.ForEach(w => w.No = 1 + Shots.FindIndex(f => f.Time == w.Time));

                if (flPanelSeries.Controls.Count > i)
                {
                    //uzupelniaj
                    SeriesRow sr = (SeriesRow)flPanelSeries.Controls[i];
                    sr.shotsSerie = serie;
                    sr.DrawNFill();
                }
                else
                {
                    //dodaj
                    AddGridAndPictureOfSeries(serie);
                }


                var sum = serie.Sum(a => a.Value);
                labSeries.Text = labSeries.Text + "  " + sum.ToString("F1");

            }


            //for (var w = 3; w < flPanelSeries.Controls.Count; w++)
            //{
            //    flPanelSeries.Controls.Remove(flPanelSeries.Controls[w]);
            //}

        }

        private void AddGridAndPictureOfSeries(List<Shot> serie)
        {
            flPanelSeries.Controls.Add(new SeriesRow(serie));
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy napewno usunąć wszystko ? ", "Ostrzeżenie", MessageBoxButtons.OKCancel);

            if (result == DialogResult.Cancel)
                return;

            Shots.Clear();
            flPanelSeries.Controls.Clear();
            labSeries.Text = string.Empty;
            RefreshTarget();
        }

        private void buttonRemLast_Click(object sender, EventArgs e)
        {
            Shots.RemoveAt(Shots.Count() - 1);

            RefreshTarget();
        }

        private void buttonRepairLast_Click(object sender, EventArgs e)
        {
            var last = Shots.Last();
            Mat frame = new Mat();
            if (string.IsNullOrWhiteSpace(last.WarpedFileName))
                return;

            string filePath = bidaSiusSettings.ImagesFolderPath + last.WarpedFileName;
            if (!File.Exists(filePath))
                return;

            Image<Bgr, Byte> ff;
            using (ff = new Image<Bgr, byte>(filePath))//.Resize(400, 400, Emgu.CV.CvEnum.Inter.Linear, true);
            {
                frame = ff.Mat;
                int czteryIpolmmR_int = CaptureHelper.GetCzteryIpolmmR_int(bidaSiusSettings);

                //odpal manualne pozycjonowanie 
                ManualShotPositioning msp = new ManualShotPositioning();
                msp.SetTargetAndShot(frame, czteryIpolmmR_int, bidaSiusSettings);
                DialogResult dr = msp.ShowDialog();
                var newShot = CaptureHelper.WyliczWartoscPrzestrzeliny(msp.SelectedPoint, bidaSiusSettings);
                last.Update(newShot);
                RefreshTarget();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds > 59)
            {
                minutes++;
                seconds = 0;
            }
            if (minutes > 59)
            {
                hours++;
                minutes = 0;
            }

            labelSeconds.Text = seconds.ToString("00");
            labelMinutes.Text = minutes.ToString("00");
            labelHours.Text = hours.ToString("00");
        }

        // ja pizgam 
        //ale jak miało by to działać qwa
        // chyba po prostu button start => odliczanie (wielki zegar) 
        // komendy czytane może przez coś 
        // i automatycznie po strzale albo po upływie czasu przełączamy na następny strzał albo komende


        //2 x 250 sek
        //14 x 50 sek

        //    start time by commanding “ATHLETES TO THE LINE.”
        //After two(2) min., the CRO will start a combined Preparation and Sighting
        //    “FIVE(5) MINUTES PREPARATION AND SIGHTING TIME…START.” 
        //    “30 SECONDS.”
        //“STOP…UNLOAD.”
        ////“FOR THE FIRST COMPETITION SERIES…
        //LOAD.” After 5 sec., the CRO will command “START.”
        //Finalists have 250 sec.to fire five(5) shots.
        //    At 250 sec.or after all finalists have fired five(5) shots, the CRO will command “STOP.”
        //Immediately after the command “STOP,” the Announcer will give 15 - 20
        //sec.of comments on the current ranking of the athletes and notable scores. Individual shot scores are not announced.
        //    Immediately after the Announcer finishes, the CRO will command “FOR
        //    THE NEXT COMPETITION SERIES, LOAD.”
        //After 5 sec., the CRO will command “START.”
        //At 250 sec.or after all finalists have fired five(5) shots, the CRO will command “STOP.”
        //Immediately after the Announcer finishes, the CRO will command “FOR
        //    THE NEXT COMPETITION SHOT, LOAD.” After 5 sec., the CRO will command “START.”
        //Finalists have 50 sec.to fire each shot.
        //    At 50 sec., the CRO will command
        //    “STOP” and the Announcer will give comments about the Finalists and
        //their scores.
        //    Immediately after the Announcer finishes, the CRO will command “FOR
        //    THE NEXT COMPETITION SHOT, LOAD.” After 5 sec., the CRO will command “START.”



    }
}
