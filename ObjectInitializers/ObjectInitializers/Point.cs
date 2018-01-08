using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    enum PointColor
    {
        LightBlue,
        BloodRed,
        Gold
    }

    class Point
    {
        // Properties
        public int X { get; set; }
        public int Y { get; set; }
        public PointColor Color { get; set; }

        public Point(int xVal, int yVal)
        {
            X = xVal;
            Y = yVal;
            Color = PointColor.Gold;
        }

        public Point(PointColor color)
        {
            Color = color;
        }

        public Point() : this(PointColor.BloodRed){ }

        public void DisplayStatus()
        {
            Console.WriteLine("[{0}, {1}]", X, Y);
            Console.WriteLine("Point is colored: {0}",Color);
        }
    }
}
