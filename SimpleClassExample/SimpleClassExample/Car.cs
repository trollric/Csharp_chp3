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

        // A custom default constructor.
        public Car()
        {
            petName = "Defaulty";
            currentSpeed = 10;
        }
        // Here currSpeed will be default in value 0
        public Car(string pn)
        {
            petName = pn;
        }
        // Let caller set the full state of the Car.
        public Car(string pn, int speed)
        {
            petName = pn;
            currentSpeed = speed;
        }

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
