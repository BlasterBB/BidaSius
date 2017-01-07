using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace BidaSius
{
    public static class TargetDrawHelper
    {
        public static Mat DrawTarget(List<Shot> Shots)
        {
            Mat obrazek = new Mat(800, 800, DepthType.Cv8U, 3);
            obrazek.SetTo(new Bgr(Color.Wheat).MCvScalar);
            Point center1 = new Point(400, 400);
            Point shot1 = new Point(430, 430);
            Point shot2 = new Point(430, 450);


            int TenRing1 = 115 / 2;
            int NineRing1 = 275 / 2;
            int EightRing1 = 435 / 2;
            int SevenRing1 = 595 / 2;
            int SixRing1 = 755 / 2;
            int FiveRing1 = 915 / 2;
            int FourRing1 = 1075 / 2;
            int ThreeRing1 = 1235 / 2;
            int TwoRing1 = 1395 / 2;
            int OneRing1 = 1555 / 2;
            int InnerTen1 = 50 / 2;
            int FourAndHalf1 = 45 / 2;
            int scalar = 2;

            CvInvoke.Circle(obrazek, center1, Convert.ToInt32(SevenRing1 / scalar), new Bgr(Color.Black).MCvScalar, -1, LineType.AntiAlias, 0);

            CvInvoke.Circle(obrazek, center1, Convert.ToInt32(InnerTen1 / scalar), new Bgr(Color.White).MCvScalar, 1, LineType.AntiAlias, 0);
            CvInvoke.Circle(obrazek, center1, Convert.ToInt32(TenRing1 / scalar), new Bgr(Color.White).MCvScalar, 1, LineType.AntiAlias, 0);
            CvInvoke.Circle(obrazek, center1, Convert.ToInt32(NineRing1 / scalar), new Bgr(Color.White).MCvScalar, 1, LineType.AntiAlias, 0);
            CvInvoke.Circle(obrazek, center1, Convert.ToInt32(EightRing1 / scalar), new Bgr(Color.White).MCvScalar, 1, LineType.AntiAlias, 0);
            CvInvoke.Circle(obrazek, center1, Convert.ToInt32(SixRing1 / scalar), new Bgr(Color.Black).MCvScalar, 1, LineType.AntiAlias, 0);
            CvInvoke.Circle(obrazek, center1, Convert.ToInt32(FiveRing1 / scalar), new Bgr(Color.Black).MCvScalar, 1, LineType.AntiAlias, 0);
            CvInvoke.Circle(obrazek, center1, Convert.ToInt32(FourRing1 / scalar), new Bgr(Color.Black).MCvScalar, 1, LineType.AntiAlias, 0);
            CvInvoke.Circle(obrazek, center1, Convert.ToInt32(ThreeRing1 / scalar), new Bgr(Color.Black).MCvScalar, 1, LineType.AntiAlias, 0);
            CvInvoke.Circle(obrazek, center1, Convert.ToInt32(TwoRing1 / scalar), new Bgr(Color.Black).MCvScalar, 1, LineType.AntiAlias, 0);
            CvInvoke.Circle(obrazek, center1, Convert.ToInt32(OneRing1 / scalar), new Bgr(Color.Black).MCvScalar, 1, LineType.AntiAlias, 0);


            Mat overlay = obrazek.Clone();

            //for (int i = 0; i < 10; i++)
            //{
            //    Point pp = new Point(shot1.X + i*mnoz, shot1.Y - i * mnoz);
            //    CvInvoke.Circle(overlay, pp, Convert.ToInt32(FourAndHalf1 / scalar), new Bgr(Color.Red).MCvScalar, -1, LineType.AntiAlias, 0);
            //   CvInvoke.Circle(overlay, pp, Convert.ToInt32(FourAndHalf1 / scalar), new Bgr(Color.White).MCvScalar, 1, LineType.AntiAlias, 0);

            //}
            int nr = 1;
            
            foreach (var sh in Shots)
            {
                Point strzalObliczonyOdSrodka = new Point(center1.X + (sh.PointFromCenter.X / scalar), center1.Y + (sh.PointFromCenter.Y / scalar));
                Point pktDlaFonta = new Point(strzalObliczonyOdSrodka.X - 2, strzalObliczonyOdSrodka.Y + 5);
                MCvScalar color = new Bgr(Color.Blue).MCvScalar;

                if (sh == Shots.Last())
                    color = new Bgr(Color.Red).MCvScalar;

                CvInvoke.Circle(overlay, strzalObliczonyOdSrodka, Convert.ToInt32(FourAndHalf1 / scalar), color, -1, LineType.AntiAlias, 0);
                CvInvoke.Circle(overlay, strzalObliczonyOdSrodka, Convert.ToInt32(FourAndHalf1 / scalar), new Bgr(Color.Black).MCvScalar, 1, LineType.AntiAlias, 0);

                CvInvoke.PutText(overlay, nr.ToString(), pktDlaFonta, FontFace.HersheyComplexSmall, 0.5, new Bgr(Color.White).MCvScalar, 1, LineType.AntiAlias, false);

                nr++;
            }

            double opacity = 0.6;
            CvInvoke.AddWeighted(overlay, opacity, obrazek, 1 - opacity, 0, obrazek);

            return obrazek;

            

        }
    }
}
