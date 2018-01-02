using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Car
    {
        // The "state" of the Car.
        public int currentSpeed;
        public string petName;

        // The functionality of the Car.
        public void speedUp(int delta)
        {
            currentSpeed += delta;
        }

        public void PrintState()
        {
            Console.WriteLine("\n{0} is going {1}KM/H.",petName,currentSpeed);
        }
    }
}
