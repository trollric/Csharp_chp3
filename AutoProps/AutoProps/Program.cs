using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Fun with Automatic properties ******\n");
            Car c = new Car();
            c.PetName = "Frank";
            c.Speed = 55;
            c.Color = "Red";
            Console.WriteLine("You car is named {0}? That's odd...",c.PetName);
            c.Dispay();
            Console.WriteLine();
            Console.WriteLine("Garage tests");
            // Put a car in the garage.
            Garage g = new Garage();
            g.MyAuto = c;
            // Ok, Prints default value of zero.
            Console.WriteLine("Number of Cars: {0}", g.NumberOfCars);
            // Runtime error! Backing field is currently null!
            Console.WriteLine(g.MyAuto.PetName);
            Console.ReadLine();
        }
    }
}
