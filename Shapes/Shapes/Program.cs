using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Polymorphism *****\n");
            Hexagon hex = new Hexagon("Beth");
            hex.Draw();
            Console.WriteLine();
            Circle cir = new Circle("Cindy");
            // Calls base class implementation
            cir.Draw();
            Console.WriteLine();

            Shape[] myShapes = { new Hexagon(), new Circle(), new Hexagon("Mick Jaeger"), new Circle("Linda"), new Hexagon("Mc Beth") };

            foreach(Shape s in myShapes)
            {
                s.Draw();
            }
            Console.WriteLine();
            ThreeDCircle d = new ThreeDCircle();
            ((Circle)d).Draw();
            d.Draw();
            Console.ReadLine();
        }
    }
}
