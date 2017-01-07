using System;
using System.Drawing;

namespace BidaSius
{
    public class Shot
    {
        public double Value { get; set; }
        public double Length { get; set; }
        public Point PointFromCenter { get; set; }
        public long Time { get; set; }
        public double SingleValue { get { return Math.Truncate(Value); } }
        public int No { get; set; }
        public String Czas { get { return new DateTime(Time).ToString("HH:mm:ss"); } }

        public override string ToString()
        {
            return Value.ToString("N1");
        }
    }
}
