using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    class Rectangle
    {
        private Point topleft = new Point();
        private Point bottomRight = new Point();

        public Point BottomRight
        {
            get { return bottomRight; }
            set { bottomRight = value; }
        }

        public Point TopLeft
        {
            get { return topleft; }
            set { topleft = value; }
        }

        public void DisplayStats()
        {
            Console.WriteLine("[TopLeft: {0}, {1}, {2} - BottomRight: {3}, {4}, {5}]",
                topleft.X,topleft.Y,topleft.Color,bottomRight.X,bottomRight.Y,bottomRight.Color);
        }
    }
}
