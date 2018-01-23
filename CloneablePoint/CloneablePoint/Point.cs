using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneablePoint
{
    class Point : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        private PointDescription desc = new PointDescription();
        public PointDescription Desc
        {
            get { return desc; }
            set { desc = value; }
        }

        public Point()
        {

        }
        public Point(int xPos, int yPos)
        {
            X = xPos; Y = yPos;
        }
        public Point(int xPos, int yPos, string petName)
        {
            X = xPos; Y = yPos;
            desc.PetName = petName;
        }

        // Override Object.ToString().
        public override string ToString()
        {
            return string.Format("X = {0}; Y = {1}; Name = {2};\nID = {3}\n", X, Y,desc.PetName,desc.PointID);
        }
        // You can simplify since Point doesn't hold any ref types
        public object Clone()
        {
            // First get a shallow copy
            Point newPoint = (Point)this.MemberwiseClone();
            // Then fill in the gaps
            PointDescription currentDesc = new PointDescription();
            currentDesc.PetName = this.desc.PetName;
            newPoint.desc = currentDesc;
            return newPoint;
        }
    }
}
