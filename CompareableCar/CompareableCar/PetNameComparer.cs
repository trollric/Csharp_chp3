using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareableCar
{
    class PetNameComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Car c1 = x as Car;
            Car c2 = y as Car;
            if(c1 != null && c2 != null)
            {
                return String.Compare(c1.PetName, c2.PetName);
            }
            else
            {
                throw new ArgumentException("One or both of the parameters are not of the Car type");
            }
        }
    }
}
