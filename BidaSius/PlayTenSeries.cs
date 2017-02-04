using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BidaSius
{
    public partial class PlayTenSeries : Form
    {
        public List<Shot> Shots = new List<Shot>();
     //   IList<Panel> tiles = new List<Panel>();

        public PlayTenSeries()
        {
            InitializeComponent();
        }

        private void numericShotsNum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Shots.Clear();
            var shotsAll = numericShotsNum.Value;
            var shotsSeries = numericShotsSeriesNum.Value;

            int ileKafelek = (int )(shotsAll / shotsSeries);

            for (int i = 0; i < ileKafelek; i++)
            {
                Panel jj = new Panel();
                jj.Name = "panel" + i.ToString();
                jj.Size = new System.Drawing.Size(40, 80);
                jj.BorderStyle = BorderStyle.FixedSingle;
                jj.BackColor = Color.Blue;       
                Label jl = new Label();
                jl.Name = "Score";
                jl.Text = "0/"+ shotsSeries;
                jj.Controls.Add(jl);


                flowLayoutPanel1.Controls.Add(jj);
              //  tiles.Add(jj);
            }

            groupSettings.Enabled = false;
        }


        public void pach()
        {
            int klocek = (int)(Shots.Count / numericShotsSeriesNum.Value);

            Color currenColor = Color.Blue;
            int currentShot = (int)(Shots.Count % numericShotsSeriesNum.Value);
            if (currentShot == 0)
            {
                currentShot = (int) numericShotsSeriesNum.Value;
                klocek--;
                var seria = Shots.OrderByDescending(x => x.Czas).Take((int) numericShotsSeriesNum.Value).ToList();
                var ijaktam = seria.Count(x => x.Value >= 10);

                currenColor = Color.Red;
                if (ijaktam == numericShotsSeriesNum.Value)
                    currenColor = Color.Green;
              
            }

            Panel selectec = (Panel)flowLayoutPanel1.Controls.Find("panel" + klocek, false).FirstOrDefault();
            if (selectec == null)
                return;

            selectec.BackColor = currenColor;
            var labe = selectec.Controls.Find("Score", false).FirstOrDefault();

            ((Label) (labe)).Text = (currentShot)  + "/" + numericShotsSeriesNum.Value;




            if (Shots.Count == (flowLayoutPanel1.Controls.Count * (int) numericShotsSeriesNum.Value))
            {
                groupSettings.Enabled = true;
            }

        }
    }
}
