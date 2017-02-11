using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace BidaSius
{
    public class ProcessFrameResult : IDisposable
    {
        public Shot Shot { get; set; }
        public Mat Oryginal { get; set; }
        public Mat SmoothedOryginal { get; set; }
        public Mat SmOryCanny { get; set; }
        public Mat FoundKontur { get; set; }
        public Mat TargetMarked { get; set; }
        public Mat Warped { get; set; }
        public Mat GrSmootWarped { get; set; }
        public Mat WarpedTargetCanny { get; set; }
        public Mat TargetScanWithResult { get; set; }
        public TargetDetails Target { get; set; }
        
        public void Dispose()
        {
            Oryginal?.Dispose();
            SmoothedOryginal?.Dispose();
            SmOryCanny?.Dispose();
            FoundKontur?.Dispose();
            TargetMarked?.Dispose();
            Warped?.Dispose();
            GrSmootWarped?.Dispose();
            WarpedTargetCanny?.Dispose();
            TargetScanWithResult?.Dispose();
        }
    }

    public class AditionaCapturelData
    {
        public TargetDetails MainTargetDetails { get; set; }
        public Mat Frame { get; set; }
        public int FirstCannyThresh { get; set; }
        public int secondCannyThresh { get; set; }
        public int firstCannyThresh1 { get; set; }
        public int secondCannyThresh1 { get; set; }
        public BidaSiusState CurrentState { get; set; }
    }

    public enum BidaSiusState
    {
        Start,
        SetTargetBoundries,
        SetTargetSizeNPosition,
        Play
    }

    public enum Games
    {
        Normal,
        Naked,
        TenSeries
    }

    [Serializable]
    public class TargetDetails
    {
        public Point TL { get; set; }
        public Point TR { get; set; }
        public Point BR { get; set; }
        public Point BL { get; set; }
        public double BlackR { get; set; }
        public Point BlackCenter { get; set; }
        public PointF[] TargetRect { get; set; }
        public bool CameraOnTop { get; set; }
        public bool CameraFlipped { get; set; }
        public bool IgnoreWhiteShots { get; set; }
        public string ImagesFolderPath { get; set; }
    }

    public static class CaptureHelper
    {

        #region pierscienie 

        /*
           10 Ring 11.5 mm(±0.1 mm) 5 Ring 91.5 mm(±0.5 mm)
           9 Ring 27.5 mm(±0.1 mm) 4 Ring 107.5 mm(±0.5 mm)
           8 Ring 43.5 mm(±0.2 mm) 3 Ring 123.5 mm(±0.5 mm)
           7 Ring 59.5 mm(±0.5 mm) 2 Ring 139.5 mm(±0.5 mm)
           6 Ring 75.5 mm(±0.5 mm) 1 Ring 155.5 mm(±0.5 mm)
           Inner ten : 5.0 mm(±0.1 mm).
           Black from 7 to 10 rings = 59.5 mm(±0.5 mm).!!!!!!!!!!!!!!!!!!
           Ring thickness : 0.1 mm to 0.2 mm.
           Minimum visible size of target card : 170 mm x 170 mm.
           */

        const int fourAndHalf = 45;
        const int innerTen = 50;
        const int tenRing = 115;
        const int nineRing = 275;
        const int eightRing = 435;
        const int sevenRing = 595;
        const int sixRing = 755;
        const int fiveRing = 915;
        const int fourRing = 1075;
        const int threeRing = 1235;
        const int twoRing = 1395;
        const int oneRing = 1555;
        const int tenRingWidth = 115;
        const int restRingWidth = 160; // to jest suma czyli 2x80


        #endregion pierscienie 


        public static ProcessFrameResult ProcessFrame(AditionaCapturelData acd)
        {

            PointF[] srcVertices;
            ProcessFrameResult result = new ProcessFrameResult();
            result.Target = new TargetDetails();
            int kwadratWidth;

            srcVertices = acd.MainTargetDetails.TargetRect;
            if (srcVertices == null)
            {
                return null;
            }
            kwadratWidth = Convert.ToInt32(srcVertices[2].X - srcVertices[3].X);

            switch (acd.CurrentState)
            {
                case BidaSiusState.Start:
                    return null;
                    break;
                case BidaSiusState.SetTargetBoundries:
                    SetTargetBoundries(srcVertices, kwadratWidth, result, acd);
                    break;
                case BidaSiusState.SetTargetSizeNPosition:
                    SetTargetSizeNPosition(srcVertices, kwadratWidth, result, acd);
                    break;
                case BidaSiusState.Play:
                    FuseThisTarget(srcVertices, kwadratWidth, result, acd);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return result;


        }

        private static void SetTargetBoundries(PointF[] src_vertices, int kwadratWidth, ProcessFrameResult result, AditionaCapturelData acd)
        {
            //pokaż wszystko na oryginalnym obrazku 
            Mat targetMarked = acd.Frame;
            CvInvoke.Polylines(targetMarked, Array.ConvertAll(src_vertices, Point.Round), true, new Bgr(Color.DarkOrange).MCvScalar, 2);
            result.TargetMarked = targetMarked;//$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
        }

        private static void SetTargetSizeNPosition(PointF[] src_vertices, int kwadratWidth, ProcessFrameResult result, AditionaCapturelData acd)
        {
            #region wyznaczenie prostokatow i kwadratow do transformacji perspektywy

            PointF[] dstVertices = new PointF[] {
                 new PointF(0,0),//tl topleft
                 new PointF(kwadratWidth, 0),//tr
                 new PointF(kwadratWidth, kwadratWidth),//br
                 new PointF(0, kwadratWidth)};//bl

            #endregion wyznaczenie prostokatow i kwadratow do transformacji perspektywy

            #region tranformacja perspektywy

            Mat warpMatrix = CvInvoke.GetPerspectiveTransform(src_vertices, dstVertices);

            Size size = new Size(kwadratWidth, kwadratWidth);
            using (Mat warped = new Mat())
            {
                CvInvoke.WarpPerspective(acd.Frame, warped, warpMatrix, size, Inter.Linear, Warp.Default);



                #endregion tranformacja perspektywy

                #region rysowanie pierscieni

                var pix = Pix(acd.MainTargetDetails.BlackR);
                DrawCircles(warped, pix, acd.MainTargetDetails.BlackCenter);
                result.Warped = warped.Clone();//$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$

            }
            #endregion rysowanie pierscieni

        }

        private static void FuseThisTarget(PointF[] src_vertices, int kwadratWidth, ProcessFrameResult result,
            AditionaCapturelData acd)
        {
            result.Target.BlackCenter = acd.MainTargetDetails.BlackCenter;
            result.Target.BlackR = acd.MainTargetDetails.BlackR;

            #region wyznaczenie prostokatow i kwadratow do transformacji perspektywy

            PointF[] dstVertices = new PointF[]
            {
                new PointF(0, 0), //tl topleft
                new PointF(kwadratWidth, 0), //tr
                new PointF(kwadratWidth, kwadratWidth), //br
                new PointF(0, kwadratWidth)
            }; //bl

            //kwadrat z lewym dolnym rogiem w tym samym miejscu co znaleziony - tylko po to żeby zobrazować
            //PointF[] dst_vertices_kwadrat_lewydol = new PointF[] {
            //     new PointF(bo_ord[3].X , bo_ord[3].Y - kwadratWidth),
            //     new PointF(bo_ord[3].X + kwadratWidth, bo_ord[3].Y - kwadratWidth),
            //     new PointF(bo_ord[3].X + kwadratWidth, bo_ord[3].Y),
            //     bo_ord[3]};

            #endregion wyznaczenie prostokatow i kwadratow do transformacji perspektywy

            using (Mat warped = new Mat())
            {
                #region tranformacja perspektywy

                Mat warpMatrix = CvInvoke.GetPerspectiveTransform(src_vertices, dstVertices);
                Size size = new Size(kwadratWidth, kwadratWidth);
                CvInvoke.WarpPerspective(acd.Frame, warped, warpMatrix, size, Inter.Linear, Warp.Default);

                #endregion tranformacja perspektywy

                #region rysowanie pierscieni

                //Mat circleImage = warped.Clone();
                var pix = Pix(acd.MainTargetDetails.BlackR);
                //DrawCircles(circleImage, pix, useThisTarget.BlackCenter);

                #endregion rysowanie pierscieni

                #region blur gray canny samej tarczy

                Mat canny_output12 = new Mat();
                Mat smallGrayFrame12 = new Mat();
                Mat smoothedGrayFrame12 = new Mat();

                CvInvoke.PyrDown(warped, smallGrayFrame12);
                CvInvoke.PyrUp(smallGrayFrame12, smoothedGrayFrame12);
                CvInvoke.CvtColor(smoothedGrayFrame12, smoothedGrayFrame12, ColorConversion.Bgr2Gray);
                // CvInvoke.GaussianBlur(smoothedGrayFrame12, smoothedGrayFrame12, new Size(9, 9), 1, 1);
                result.SmoothedOryginal = smoothedGrayFrame12;


                #region test

                CvInvoke.Canny(smoothedGrayFrame12, canny_output12, acd.FirstCannyThresh, acd.secondCannyThresh);

                #endregion test

                #endregion blur gray canny samej tarczy

                #region rozpoznawanie strzału

                int czteryIpolmmRInt = Convert.ToInt32(FourNHalfR(pix));
                int zapasSize = 5;

                CircleF[] przestrzeliny = CvInvoke.HoughCircles(smoothedGrayFrame12,
                    HoughType.Gradient,
                    1,
                    400,
                    acd.firstCannyThresh1,
                    acd.secondCannyThresh1,
                    czteryIpolmmRInt - zapasSize,
                    czteryIpolmmRInt + zapasSize);

                result.Warped = warped.Clone();//$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$

                foreach (CircleF shot in przestrzeliny)
                {
                    CvInvoke.Circle(warped, Point.Round(shot.Center), czteryIpolmmRInt, new Bgr(Color.Blue).MCvScalar, 1,
                        LineType.AntiAlias, 0);
                    CvInvoke.Circle(warped, Point.Round(shot.Center), czteryIpolmmRInt - zapasSize,
                        new Bgr(Color.BlueViolet).MCvScalar, 1, LineType.AntiAlias, 0);
                    CvInvoke.Circle(warped, Point.Round(shot.Center), czteryIpolmmRInt + zapasSize,
                        new Bgr(Color.Chartreuse).MCvScalar, 1, LineType.AntiAlias, 0);

                    result.Shot = WyliczWartoscPrzestrzeliny(shot.Center, acd.MainTargetDetails);
                    result.TargetScanWithResult = warped.Clone();//$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
                    break;
                }

                #endregion

            }
        }

        public static ProcessFrameResult ProcessFromFile(Mat frame, int firstCannyThresh = 100, int secondCannyThresh = 60, int firstCannyThresh1 = 120, int secondCannyThresh1 = 50, TargetDetails useThisTarget = null)
        {

            ProcessFrameResult result = new ProcessFrameResult();

            result.Target = new TargetDetails();
            result.Target.BlackCenter = useThisTarget.BlackCenter;
            result.Target.BlackR = useThisTarget.BlackR;

            var pix = Pix(useThisTarget.BlackR);
            int zapasSize = 5; //zapas z jakim ma wykrywać przestrzeline - to wywalić do jakiegoś txtbox czy coś
            int czteryIpolmmR_int = Convert.ToInt32(FourNHalfR(pix));


            Mat circleImage = frame;

            #region hocki klocki przepierdalanie obrazu

            var inputImage = frame.ToImage<Bgr, byte>();
            // inputImage._EqualizeHist();
            inputImage._GammaCorrect(0.4d);
            result.GrSmootWarped = inputImage.Mat;

            #region blur gray canny samej tarczy

            Mat canny_output12 = new Mat();
            //As for your answer to number two, blur the image, convert to greyscale, then threshold to eliminate lighting differences is the usual solution

            Mat smallGrayFrame12 = new Mat();
            Mat smoothedGrayFrame12 = new Mat();
            CvInvoke.PyrDown(inputImage.Mat, smallGrayFrame12);
            CvInvoke.PyrUp(smallGrayFrame12, smoothedGrayFrame12);
            CvInvoke.CvtColor(smoothedGrayFrame12, smoothedGrayFrame12, ColorConversion.Bgr2Gray);
            // CvInvoke.GaussianBlur(smoothedGrayFrame12, smoothedGrayFrame12, new Size(9, 9), 1, 1);
            result.SmoothedOryginal = smoothedGrayFrame12;


            #region test
            //#######test

            //                   double otsu_thresh_val12 = CvInvoke.Threshold(smoothedGrayFrame12, fake12, firstCannyThresh, secondCannyThresh, ThresholdType.Binary & ThresholdType.Otsu);
            //CvInvoke.AdaptiveThreshold(smoothedGrayFrame12, fake12, 255, AdaptiveThresholdType.GaussianC, ThresholdType.BinaryInv, 3, 2);
            //1CvInvoke.GaussianBlur(fake12, fake12, new Size(9, 9), 1, 1);
            //  CvInvoke.GaussianBlur(fake12, fake12, new Size(9, 9), 1, 1);
            //    C1111vInvoke.GaussianBlur(fake12, fake12, new Size(9, 9), 1, 1);
            //            We don't need the _img. We are interested in only the otsu_thresh_val but unfortunately, currently there is no method in OpenCV which allows you to compute only the threshold value.

            //Use the Otsu's threshold value as higher threshold and half of the same as the lower threshold for Canny's algorithm.

            //double high_thresh_val1 = otsu_thresh_val1,
            //       lower_thresh_val1 = otsu_thresh_val1 * 0.5;




            //CvInvoke.GaussianBlur(warped, fake12, new Size(9, 9), 1, 1);
            CvInvoke.Canny(smoothedGrayFrame12, canny_output12, firstCannyThresh, secondCannyThresh);
            //                    CvInvoke.Canny(smoothedGrayFrame12, canny_output12, 120, 50);
            // CvInvoke.GaussianBlur(canny_output12, canny_output12, new Size(11, 11), 1, 1);
            //    CvInvoke.GaussianBlur(canny_output12, canny_output12, new Size(7, 7), 1, 1);

            // result.WarpedTargetCanny = canny_output12;//$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
            //#######test
            #endregion test

            #endregion blur gray canny samej tarczy


            // result.SmOryCanny = smoothedGrayFrame12;

            #endregion  hocki klocki przepierdalanie obrazu


            //odpal manualne pozycjonowanie 
            ManualShotPositioning msp = new ManualShotPositioning();
            msp.SetTargetAndShot(circleImage, czteryIpolmmR_int, useThisTarget);
            DialogResult dr = msp.ShowDialog();
            CvInvoke.Circle(circleImage, Point.Round(msp.SelectedPoint), czteryIpolmmR_int, new Bgr(Color.DeepPink).MCvScalar, 1, LineType.AntiAlias, 0);
            result.Shot = WyliczWartoscPrzestrzeliny(msp.SelectedPoint, useThisTarget);
            DrawCircles(circleImage, pix, useThisTarget.BlackCenter);
            result.TargetScanWithResult = circleImage;//$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$

            return result;

        }

        public static int GetCzteryIpolmmR_int(TargetDetails settings)
        {
            var pix = CaptureHelper.Pix(settings.BlackR);
            return Convert.ToInt32(CaptureHelper.FourNHalfR(pix));

        }

        private static double Pix(double radius)
        {
            double pix = sevenRing / (2 * radius);
            return pix;
        }

        #region get ring radius

        public static double GetRingR(double pix, int ring)
        {
            double ringR = (ring / pix) / 2;
            return ringR;
        }

        private static double InnerTenR(double pix)
        {
            return GetRingR(pix, innerTen);
        }
        private static double TenR(double pix)
        {
            return GetRingR(pix, tenRing);
        }
        private static double NineR(double pix)
        {
            return GetRingR(pix, nineRing);
        }
        private static double EightR(double pix)
        {
            return GetRingR(pix, eightRing);
        }
        private static double SevenR(double pix)
        {
            return GetRingR(pix, sevenRing);
        }
        private static double SixR(double pix)
        {
            return GetRingR(pix, sixRing);
        }
        private static double FiveR(double pix)
        {
            return GetRingR(pix, fiveRing);
        }
        private static double FourR(double pix)
        {
            return GetRingR(pix, fourRing);
        }
        private static double ThreeR(double pix)
        {
            return GetRingR(pix, threeRing);
        }
        private static double TwoR(double pix)
        {
            return GetRingR(pix, twoRing);
        }
        private static double OneR(double pix)
        {
            return GetRingR(pix, oneRing);
        }
        private static double FourNHalfR(double pix)
        {
            return GetRingR(pix, fourAndHalf);
        }
        #endregion get ring radius

        #region wyliczanie przestrzeliny

        public static Shot WyliczWartoscPrzestrzeliny(PointF shotPoint, TargetDetails targetDet)
        {
            double wartosc = 0;
            Shot sh = new Shot();
            double pix = Pix(targetDet.BlackR);



            Point shotCenter = Point.Round(shotPoint);
            var diffX = shotCenter.X - targetDet.BlackCenter.X;
            var diffY = shotCenter.Y - targetDet.BlackCenter.Y;
            double odlegl = Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2));
            sh.Length = odlegl * pix;

            double dziesietna = (restRingWidth / pix) / 2; //dziesietna dla pierscieni 9 -- 
            double dziesietna1 = dziesietna / 10;

            double dziesietna10 = ((tenRingWidth + innerTen) / pix) / 2;// dziesietna dla 10 
            double dziesietna11 = dziesietna10 / 10;
            double czteryiPolmmR = FourNHalfR(pix);
            double dl = odlegl - czteryiPolmmR;

            //  Point strzalObliczonyOdSrodka = new Point(center.X + diffX, center.Y + diffY);

            Point strzalObliczonyOdSrodkaPix;
            if (targetDet.CameraFlipped)
                strzalObliczonyOdSrodkaPix = new Point(-Convert.ToInt32(diffX * pix), -Convert.ToInt32(diffY * pix));
            else
                strzalObliczonyOdSrodkaPix = new Point(Convert.ToInt32(diffX * pix), Convert.ToInt32(diffY * pix));

            sh.PointFromCenter = strzalObliczonyOdSrodkaPix;

            //sprawdzenie wartości strzału
            if (dl <= TenR(pix))
                wartosc = CountdziesietneDycha(10, odlegl, czteryiPolmmR, TenR(pix), dziesietna11, InnerTenR(pix));
            else if (dl <= NineR(pix))
                wartosc = Countdziesietne(9, odlegl, czteryiPolmmR, NineR(pix), dziesietna1);
            else if (dl <= EightR(pix))
                wartosc = Countdziesietne(8, odlegl, czteryiPolmmR, EightR(pix), dziesietna1);
            else if (dl <= SevenR(pix))
                wartosc = Countdziesietne(7, odlegl, czteryiPolmmR, SevenR(pix), dziesietna1);
            else if (dl <= SixR(pix))
                wartosc = Countdziesietne(6, odlegl, czteryiPolmmR, SixR(pix), dziesietna1);
            else if (dl <= FiveR(pix))
                wartosc = Countdziesietne(5, odlegl, czteryiPolmmR, FiveR(pix), dziesietna1);
            else if (dl <= FourR(pix))
                wartosc = Countdziesietne(4, odlegl, czteryiPolmmR, FourR(pix), dziesietna1);
            else if (dl <= ThreeR(pix))
                wartosc = Countdziesietne(3, odlegl, czteryiPolmmR, ThreeR(pix), dziesietna1);
            else if (dl <= TwoR(pix))
                wartosc = Countdziesietne(2, odlegl, czteryiPolmmR, TwoR(pix), dziesietna1);
            else if (dl <= OneR(pix))
                wartosc = Countdziesietne(1, odlegl, czteryiPolmmR, OneR(pix), dziesietna1);


            sh.Value = wartosc;
            sh.Time = DateTime.Now.Ticks;
            return sh;
        }


        private static double Countdziesietne(double ring, double odlegl, double czteryiPolmmR, double pier, double dziesietna1)
        {
            double wartosc = 0;
            for (int i = 0; i < 10; i++)
            {
                if (odlegl - czteryiPolmmR <= pier - dziesietna1 * i)
                {
                    wartosc = ring + 0.1 * i;
                }
            }

            // CvInvoke.PutText(obrazek, wartosc.ToString(), new Point(30, 30), FontFace.HersheyComplexSmall, 2, new Bgr(Color.Green).MCvScalar);
            return wartosc;
        }


        private static double CountdziesietneDycha(double ring, double odlegl, double czteryiPolmmR, double pier, double dziesietna1, double innerTenR)
        {
            double wartosc = 0;
            for (int i = 0; i < 10; i++)
            {
                if (odlegl - czteryiPolmmR + innerTenR <= pier + innerTenR - (dziesietna1 * i))
                {
                    wartosc = ring + 0.1 * i;
                }
            }

            // CvInvoke.PutText(obrazek, wartosc.ToString(), new Point(30, 30), FontFace.HersheyComplexSmall, 2, new Bgr(Color.Green).MCvScalar);
            return wartosc;
        }

        #endregion wyliczanie przestrzeliny

        #region rysowanie

        public static void DrawCircles(Mat image, double pix, Point center)
        {
            CvInvoke.Circle(image, center, Convert.ToInt32(InnerTenR(pix)), new Bgr(Color.White).MCvScalar, 1, LineType.AntiAlias, 0);
            CvInvoke.Circle(image, center, Convert.ToInt32(TenR(pix)), new Bgr(Color.White).MCvScalar, 1, LineType.AntiAlias, 0);
            CvInvoke.Circle(image, center, Convert.ToInt32(NineR(pix)), new Bgr(Color.White).MCvScalar, 1, LineType.AntiAlias, 0);
            CvInvoke.Circle(image, center, Convert.ToInt32(EightR(pix)), new Bgr(Color.White).MCvScalar, 1, LineType.AntiAlias, 0);
            CvInvoke.Circle(image, center, Convert.ToInt32(SevenR(pix)), new Bgr(Color.White).MCvScalar, 1, LineType.AntiAlias, 0);
            CvInvoke.Circle(image, center, Convert.ToInt32(SixR(pix)), new Bgr(Color.Black).MCvScalar, 1, LineType.AntiAlias, 0);
            CvInvoke.Circle(image, center, Convert.ToInt32(FiveR(pix)), new Bgr(Color.Black).MCvScalar, 1, LineType.AntiAlias, 0);
            CvInvoke.Circle(image, center, Convert.ToInt32(FourR(pix)), new Bgr(Color.Black).MCvScalar, 1, LineType.AntiAlias, 0);
            CvInvoke.Circle(image, center, Convert.ToInt32(ThreeR(pix)), new Bgr(Color.Black).MCvScalar, 1, LineType.AntiAlias, 0);
            CvInvoke.Circle(image, center, Convert.ToInt32(TwoR(pix)), new Bgr(Color.Black).MCvScalar, 1, LineType.AntiAlias, 0);
            CvInvoke.Circle(image, center, Convert.ToInt32(OneR(pix)), new Bgr(Color.Black).MCvScalar, 1, LineType.AntiAlias, 0);
        }

        #endregion

        public static ProcessFrameResult ManualProcessFrame(Mat frame, int firstCannyThresh = 100, int secondCannyThresh = 60, int firstCannyThresh1 = 120, int secondCannyThresh1 = 50, TargetDetails useThisTarget = null)
        {
            PointF[] srcVertices;
            int kwadratWidth;

            srcVertices = useThisTarget.TargetRect;
            if (srcVertices == null)
            {
                return null;
            }
            kwadratWidth = Convert.ToInt32(srcVertices[2].X - srcVertices[3].X);


            #region wyznaczenie prostokatow i kwadratow do transformacji perspektywy

            PointF[] dstVertices = new PointF[] {
                 new PointF(0,0),//tl topleft
                 new PointF(kwadratWidth, 0),//tr
                 new PointF(kwadratWidth, kwadratWidth),//br
                 new PointF(0, kwadratWidth)};//bl


            #endregion wyznaczenie prostokatow i kwadratow do transformacji perspektywy

            #region tranformacja perspektywy
            Mat warpMatrix = CvInvoke.GetPerspectiveTransform(srcVertices, dstVertices);
            Mat warped = new Mat();
            Size size = new Size(kwadratWidth, kwadratWidth);
            CvInvoke.WarpPerspective(frame, warped, warpMatrix, size, Inter.Linear, Warp.Default);
            // result.Warped = warped;//$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
            #endregion tranformacja perspektywy


            return ProcessFromFile(warped, firstCannyThresh, secondCannyThresh, firstCannyThresh1, secondCannyThresh1, useThisTarget);


        }



    }
}
