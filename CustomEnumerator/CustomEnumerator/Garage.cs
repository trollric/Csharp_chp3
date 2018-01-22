using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumerator
{
    // Garage contains a set of Car objects.
    public class Garage : IEnumerable
    {
        private Car[] carArray = new Car[4];
        // Fill the Garage with some sweet cars on startup.
        public Garage()
        {
            carArray[0] = new Car("Ruzty", 30);
            carArray[1] = new Car("Clunker", 55);
            carArray[2] = new Car("Zippy", 30);
            carArray[3] = new Car("Fred", 30);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return carArray.GetEnumerator();
        }
    }
}
