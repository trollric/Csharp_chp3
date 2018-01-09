using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Basic Inheritence ******\n");
            // Make a Car Object an set max speed.
            Car myCar = new Car(80) { Speed = 50 };
            // Set the current speed and print it
            Console.WriteLine("My car is going {0} KMH",myCar.Speed);
            Console.WriteLine();

            // Now make a Minivan object.
            MiniVan myVan = new MiniVan() { Speed = 10 };
            Console.WriteLine("My Van is going {0} KMH.",myVan.Speed);
            Console.ReadLine();
        }
    }
}
