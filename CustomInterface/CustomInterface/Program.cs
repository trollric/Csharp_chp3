using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Fun with Interfaces ******\n");
            // Call points property defined by IPointy
            Hexagon hex = new Hexagon("Johannes");
            Console.WriteLine("The Hexagon {0} has {1} Points",hex.PetName,hex.Points);
            Console.WriteLine("\n Now with error handling");
            Circle c = new Circle("Lisa");
            IPointy itfPt = null;
            try
            {
                itfPt = (IPointy)c;
                Console.WriteLine(itfPt.Points);
            }
            catch(InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
            TestWithTheAsKeyword();
            TestWithTheIsKeyword();
            Console.ReadLine();
        }

        private static void TestWithTheIsKeyword()
        {
            Console.WriteLine();
            Shape[] myShapes = { new Hexagon(), new Circle(), new Triangle("Joe"), new Circle("Jojo") };
            for (int i = 0; i < myShapes.Length; i++)
            {
                // Recall the Shape base class defines an abstract Draw()
                // member, so all shapes know how to draw themselves.
                myShapes[i].Draw();
                // Who's pointy?
                if(myShapes[i] is IPointy)
                {
                    Console.WriteLine("-> Points = {0}",((IPointy)myShapes[i]).Points);
                }
                else
                {
                    Console.WriteLine("-> {0}'s not pointy!",myShapes[i].PetName);
                }
            }
        }

        private static void TestWithTheAsKeyword()
        {
            // Can we treat hex2 as IPointy?
            Hexagon hex2 = new Hexagon("Peter");
            IPointy itfPt2 = hex2 as IPointy;
            if(itfPt2 != null)
                Console.WriteLine("\nPoints: {0}", itfPt2.Points);
            else
                Console.WriteLine("\nOooops! That was not pointy");
        }
    }
}
