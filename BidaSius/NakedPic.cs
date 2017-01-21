using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BidaSius
{
    public partial class NakedPic : Form
    {
        IList<Panel> tiles = new List<Panel>();
        Timer myTimer = new Timer();
        private int missed = 0;
        private int hit = 0;
        public List<Shot> Shots = new List<Shot>();

        public NakedPic()
        {
            InitializeComponent();
            ReloadImage();
            myTimer.Interval = 3000;
            myTimer.Tick += new System.EventHandler(timer1_Tick);
        }

        public void ReloadImage()
        {
            WebClient client = new WebClient();
            string downloadString = client.DownloadString("http://www.share-image.com/random");
            if (downloadString.Contains("http://pictures.share-image.com/pictures/big"))
            {
                Regex regex = new Regex(@"http://pictures.share-image.com/pictures/big/.*\.jpg");
                Match match = regex.Match(downloadString);
                if (match.Success)
                {
                    Console.WriteLine(match.Value);
                    pictureBox1.ImageLocation = match.Value;

                }
            }
        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            var nn = pictureBox1.Image.Width / 6;
            var pp = pictureBox1.Image.Height / 3;

            tiles.Clear();

            var point = new System.Drawing.Point(0, 0);
            for (int j = 0; j < 3; j++)
            {
                point = new Point(point.X, point.Y);
                for (int i = 0; i < 6; i++)
                {
                    Panel jj = new Panel();
                    jj.Location = new System.Drawing.Point(nn * i, pp * j);
                    jj.Name = "panel" + DateTime.Now.Ticks;
                    jj.Size = new System.Drawing.Size(nn, pp);
                    jj.BorderStyle = BorderStyle.FixedSingle;
                    pictureBox1.Controls.Add(jj);
                    tiles.Add(jj);
                }
            }
        }
      
        public void HideOneTile()
        {
            hit++;
            ShowScore();
            var visibles = tiles.Where(x => x.Visible == true).ToList();
            if (visibles.Count == 0)
                return;
            Random rnd = new Random();
            int r = rnd.Next(visibles.Count);
            visibles[r].Visible = false;
            if (visibles.Count == 1)
                myTimer.Start();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            myTimer.Enabled = false;
            ReloadImage();
        }

        public void Missed()
        {
            missed++;
            ShowScore();
        }

        private void ShowScore()
        {
            this.Text = "Hits:" + hit.ToString() + " / Missed:" + missed.ToString();
        }
    }
}

