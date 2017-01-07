using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Emgu.CV.UI;
using tarcza;

namespace BidaSius
{
    public partial class SeriesRow : UserControl
    {

        public List<Shot> shotsSerie = new List<Shot>();


        public SeriesRow(List<Shot> shots)
        {
            InitializeComponent();
            shotsSerie = shots;
            if (shotsSerie.Count > 0)
                DrawNFill();
        }

        public void DrawNFill()
        {


            //pictureBox1.Image = TargetDrawHelper.DrawTarget(shotsSerie).Bitmap
            //  pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            imageBox1.Image = TargetDrawHelper.DrawTarget(shotsSerie);
            imageBox1.FunctionalMode = ImageBox.FunctionalModeOption.Minimum;
            imageBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            var sum = shotsSerie.Sum(a => a.SingleValue);
            var sumP = shotsSerie.Sum(a => a.Value);
            labSerieTotal.Text = sum.ToString() + " (" + sumP.ToString() + ") ";
            dataGridViewSerie.RowHeadersVisible = false;
            dataGridViewSerie.DataSource = shotsSerie;


        }
    }
}
