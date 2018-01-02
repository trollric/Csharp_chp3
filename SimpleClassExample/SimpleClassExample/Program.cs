using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Fun with Class Types ******\n");
            // Allocate and configure a Car object.
            Car myCar = new Car();
            myCar.petName = "Henry";
            myCar.currentSpeed = 10;
            // Speed up the car a few times and print out the
            // new state.
            for (int i = 0; i < 10; i++)
            {
                myCar.speedUp(5);
                myCar.PrintState();
            }
            // default constructor
            myCar = new Car();
            myCar.PrintState();

            // Try starting with a chosen name but default speed.
            myCar = new Car("Kirby");
            myCar.PrintState();

            // Chose all starting parameters
            myCar = new Car("Stringy", 22);
            myCar.PrintState();

            Motorcycle mc = new Motorcycle(5);
            mc.SetDriversName("Tiny");
            mc.PopAWheely();
            mc = new Motorcycle("Namey booooi!");
            mc.PopAWheely();

            Console.WriteLine();
            MakeSomeSportsCars();

            Console.ReadLine();
        }

        private static void MakeSomeSportsCars()
        {
            // name = "default", speed = 10
            SportsCar c1 = new SportsCar();
            c1.Display();

            SportsCar c2 = new SportsCar("Tanky");
            c2.Display();

            SportsCar c3 = new SportsCar(speed: 14);
            c3.Display();

            SportsCar c4 = new SportsCar(name: "Chubby", speed: 25);
            c4.Display();

        }
    }
}
