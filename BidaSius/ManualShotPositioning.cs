using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Emgu.CV;
using tarcza;

namespace BidaSius
{
    public partial class ManualShotPositioning : Form
    {
        public ManualShotPositioning()
        {
            InitializeComponent();
        }

        private Bitmap ShotMark;
        private Rectangle ShotMarkLocation;
        private TargetDetails TargetDet;
        private int rozmiarObrazka;
        private Mat targetMat;

        public Point SelectedPoint {
            get { return new Point(ShotMarkLocation.X + rozmiarObrazka/2, ShotMarkLocation.Y + rozmiarObrazka / 2);}
        }

      

        public void SetTargetAndShot(Mat target, int czteryIpol, TargetDetails targetDet)
        {
            targetMat = target;
            TargetDet = targetDet;
            pictureBTarget.Image = target.Bitmap;

            rozmiarObrazka = czteryIpol * 2 + 1;
            Bitmap flag = new Bitmap(rozmiarObrazka, rozmiarObrazka);
            // Bitmap flag = new Bitmap(101, 101);
            Graphics flagGraphics = Graphics.FromImage(flag);

            // Create solid brush.
           // SolidBrush blueBrush = new SolidBrush(Color.Blue);
          //  flagGraphics.FillRectangle(blueBrush, new Rectangle(0, 0, rozmiarObrazka, rozmiarObrazka));
          


            Rectangle rectangle = new Rectangle(0, 0, czteryIpol * 2, czteryIpol * 2);
           // flagGraphics.fil
            // Rectangle rectangle = new Rectangle(0, 0, 100,100);
            flagGraphics.DrawEllipse(new Pen(Color.Red, 1), rectangle);
            ShotMark = flag;

        }




        private void ManualShotPositioning_Load(object sender, EventArgs e)
        {
            // Make the white pixels in the smiley transparent.
            //  ShotMark = new Bitmap(Properties.Resources.smile);
            ShotMark.MakeTransparent(Color.White);

            // Set the smiley's initial location.
            ShotMarkLocation = new Rectangle(TargetDet.BlackCenter.X, TargetDet.BlackCenter.Y, ShotMark.Width, ShotMark.Height);
        }

        private void pictureBTarget_Paint(object sender, PaintEventArgs e)
        {
            // Draw the picture over the background.
            e.Graphics.DrawImage(ShotMark, ShotMarkLocation);
        }




        // True when we are dragging.
        private bool Dragging = false;

        // The offset from the mouse's down position
        // and the picture's upper left corner.
        private int OffsetX, OffsetY;

        // Start dragging the picture.
        private void picBackground_MouseDown(object sender, MouseEventArgs e)
        {
            // See if we're over the picture.
            if (PointIsOverPicture(e.X, e.Y))
            {
                // Start dragging.
                Dragging = true;

                // Save the offset from the mouse to the picture's origin.
                OffsetX = ShotMarkLocation.X - e.X;
                OffsetY = ShotMarkLocation.Y - e.Y;
            }
        }

        // Continue dragging the picture.
        private void picBackground_MouseMove(object sender, MouseEventArgs e)
        {
            // See if we're dragging.
            if (Dragging)
            {
                // We're dragging the image. Move it.
                ShotMarkLocation.X = e.X + OffsetX;
                ShotMarkLocation.Y = e.Y + OffsetY;
                labelValue.Text = GetShotValue();
                labelValue.BackColor = Color.Transparent;
                // Redraw.
                pictureBTarget.Invalidate();

            }
            else
            {
                // We're not dragging the image. See if we're over it.
                Cursor new_cursor = Cursors.Default;
                if (PointIsOverPicture(e.X, e.Y))
                {
                    new_cursor = Cursors.Hand;
                }
                if (pictureBTarget.Cursor != new_cursor)
                    pictureBTarget.Cursor = new_cursor;
            }
        }

        // Stop dragging the picture.
        private void picBackground_MouseUp(object sender, MouseEventArgs e)
        {
           

            // Redraw.
        //    pictureBTarget.Invalidate();

            Dragging = false;
        }

        // Return true if the point is over the picture's current location.
        private bool PointIsOverPicture(int x, int y)
        {
            // See if it's over the picture's bounding rectangle.
            if ((x < ShotMarkLocation.Left) || (x >= ShotMarkLocation.Right) ||
                (y < ShotMarkLocation.Top) || (y >= ShotMarkLocation.Bottom))
                return false;
            else
            {
                return true;
            }

            // See if the point is above a non-transparent pixel.
            int i = x - ShotMarkLocation.X;
            int j = y - ShotMarkLocation.Y;
            return (ShotMark.GetPixel(i, j).A > 0);
        }



        private string GetShotValue()
        {
            var przestrz = CaptureHelper.WyliczWartoscPrzestrzeliny(SelectedPoint, TargetDet);
            return przestrz.ToString();

        }


        private void UpdateTarget()
        {

            Bitmap bmp = targetMat.Clone().Bitmap;

            RectangleF rectf = new RectangleF(70, 90, 90, 50);

            Graphics g = Graphics.FromImage(bmp);

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;


            g.DrawString(GetShotValue(), new Font("Tahoma", 8), Brushes.Black, rectf);

            g.Flush();

            pictureBTarget.Image = bmp;
        }
    }
}
