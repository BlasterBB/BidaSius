using System.Drawing;
using System.Linq;
using Emgu.CV.Structure;

namespace BidaSius
{
    public class FoundRectangles
    {
        public RotatedRect minAreaRect { get; set; }
        public Point[] foundedContour { get; set; }


        public Point[] foundedContourOrdered()
        {
            var left = foundedContour.OrderBy(a => a.X).Take(2).ToList();
            var right = foundedContour.OrderByDescending(a => a.X).Take(2).ToList();

            Point lg = left.OrderBy(a => a.Y).First();
            Point ld = left.OrderByDescending(a => a.Y).First();

            Point pg = right.OrderBy(a => a.Y).First();
            Point pd = right.OrderByDescending(a => a.Y).First();

            return new Point[] {
               lg,//tl
                pg,//tr
               pd,//br
                ld};//bl

        }
    }
}
