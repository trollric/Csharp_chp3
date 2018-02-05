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
            set { yPos = value}
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
        }
    }
}
