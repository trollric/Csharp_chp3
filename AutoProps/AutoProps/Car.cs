using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    class Car
    {
        // Automatic properies! No need
        // to define backing fields.
        public string PetName { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }

        public void Dispay()
        {
            Console.WriteLine("Car name: {0}",PetName);
            Console.WriteLine("Speed: {0}",Speed);
            Console.WriteLine("Color: {0}",Color);
        }
    }
}
