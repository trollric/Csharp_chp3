using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Init Syntax *****\n");
            // Make a Point by setting each property manually.
            Point firstPoint = new Point();
            firstPoint.X = 10;
            firstPoint.Y = 10;
            firstPoint.DisplayStatus();

            // Or make a Point via the custom constructor.
            Point anotherPoint = new Point(20, 20);
            anotherPoint.DisplayStatus();

            // Or make a point using object init syntax.
            Point finalPoint = new Point { X = 30, Y = 30 };
            finalPoint.DisplayStatus();

            // now we can call a light blue point color with the cordinates 90,20
            Point oneMorePoint = new Point(PointColor.LightBlue) { X = 90, Y = 20 };
            oneMorePoint.DisplayStatus();

            // Create and initialize a Rectangle.
            Rectangle myRectangle = new Rectangle { TopLeft = new Point { X = 10, Y = 10 }, BottomRight = new Point { X = 200, Y = 200 } };
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
