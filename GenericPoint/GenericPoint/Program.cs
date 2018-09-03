using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPoint
{
    public struct Point<T>
    {
        // Generic state
        private T xPos;
        private T yPos;
        // Generic properties
        public T X
        {
            get { return xPos; }
            set { xPos = value; }
        }
        public T Y
        {
            get { return yPos; }
            set { yPos = value; }
        }
        // Generic constructor.
        public Point(T xVal, T yVal)
        {
            xPos = xVal;
            yPos = yVal;
        }
        // Generic Methods
        public override string ToString()
        {
            return string.Format("[{0}, {1}]", xPos, yPos);
        }
        public void ResetPoint()
        {
            xPos = default(T);
            yPos = default(T);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Generic Structures *****\n");
            // Point using ints
            Point<int> p = new Point<int>(10, 10);
            Console.WriteLine("p.toString() = {0}", p.ToString());
            p.ResetPoint();
            Console.WriteLine("p.toString() = {0}",p.ToString());
            Console.WriteLine();
            // Points using doubles
            Point<double> p2= new Point<double>(5.4, 3.2);
            Console.WriteLine("p2.toString() = {0}", p2.ToString());
            p2.ResetPoint();
            Console.WriteLine("p2.toString() = {0}", p2.ToString());
            Console.ReadLine();

        }
    }
}
