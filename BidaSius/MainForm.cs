using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using tarcza;

namespace BidaSius
{
    public partial class MainForm : Form
    {
        public List<Shot> Shots = new List<Shot>();


        public MainForm()
        {
            InitializeComponent();
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
            Shots.Add(new Shot { No = 1, Value = 10.1, Time = DateTime.Now.Ticks + 49, PointFromCenter = new Point { X = 27, Y = 25 } });
            Shots.Add(new Shot { No = 1, Value = 10.2, Time = DateTime.Now.Ticks + 50, PointFromCenter = new Point { X = 22, Y = 23 } });
            Shots.Add(new Shot { No = 1, Value = 10.4, Time = DateTime.Now.Ticks + 467, PointFromCenter = new Point { X = 34, Y = 11 } });
            Shots.Add(new Shot { No = 1, Value = 10.2, Time = DateTime.Now.Ticks + 400, PointFromCenter = new Point { X = 45, Y = 66 } });
            Shots.Add(new Shot { No = 1, Value = 7, Time = DateTime.Now.Ticks + 83, PointFromCenter = new Point { X = 21, Y = 34 } });
            Shots.Add(new Shot { No = 1, Value = 8, Time = DateTime.Now.Ticks + 150, PointFromCenter = new Point { X = 20, Y = 55 } });
            Shots.Add(new Shot { No = 1, Value = 9.7, Time = DateTime.Now.Ticks + 140, PointFromCenter = new Point { X = 10, Y = 32 } });

         //   flPanelSeries.Controls.Add(new testUC());


            RefreshTarget();


        }

        public void RefreshTarget()
        {
            DrawAllTarget();
            var sum = Shots.Sum(a => a.SingleValue);
            var sumP = Shots.Sum(a => a.Value);
            var sumTxt = sum.ToString() + " (" + sumP.ToString() + ") ";
            labelSum.Text = sumTxt;

            AddSeriesRows();
            if (flPanelSeries.Controls.Count > 0)
                flPanelSeries.ScrollControlIntoView(flPanelSeries.Controls[flPanelSeries.Controls.Count - 1]);
        }

        private void DrawAllTarget()
        {
            TargetIB.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.PanAndZoom;
            if (chckShowAll.Checked)
                TargetIB.Image = TargetDrawHelper.DrawTarget(Shots);
            else
            {
                var sss = (Shots.Count() / 10) * 10;
                var skip = sss;
                if (Shots.Count() % 10 == 0)
                    skip = sss - 10;

                var serie = Shots.Skip(Math.Max(0, skip)).ToList();
                TargetIB.Image = TargetDrawHelper.DrawTarget(serie);
            }
            TargetIB.HideScrolls = false;
        }

        private void AddSeriesRows()
        {
            int series = Shots.Count() / 10;
            if (series * 10 < Shots.Count())
                series++;
            labSeries.Text = string.Empty;


            for (int i = 0; i < series; i++)
            {
                var serie = Shots.Skip(i * 10).Take(10).ToList();
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


                var sum = serie.Sum(a => a.SingleValue);
                labSeries.Text = labSeries.Text + "  " + sum.ToString();

            }


            for (var w = series; w < flPanelSeries.Controls.Count; w++)
            {
                flPanelSeries.Controls.Remove(flPanelSeries.Controls[w]);
            }

        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            ShowSettings();
        }

        private void ShowSettings()
        {
            if (ccForm != null)
            {
                ccForm.BringToFront();
            }
            else
            {
                ccForm = new CameraCapture();
                ccForm.MainF = this;
                ccForm.Show();
            }
        }

        private void AddGridAndPictureOfSeries(List<Shot> serie)
        {
            flPanelSeries.Controls.Add(new SeriesRow(serie));

        }

        CameraCapture ccForm = null;

        private void ccForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ccForm = null;
        }


        private void buttonClean_Click(object sender, EventArgs e)
        {
            Shots.Clear();
            flPanelSeries.Controls.Clear();
            labSeries.Text = string.Empty;
            RefreshTarget();
        }

        private void chckShowAll_CheckedChanged(object sender, EventArgs e)
        {
            DrawAllTarget();
        }

        private void buttonRemLast_Click(object sender, EventArgs e)
        {
            Shots.RemoveAt(Shots.Count() - 1);

            RefreshTarget();
        }
    }
}
