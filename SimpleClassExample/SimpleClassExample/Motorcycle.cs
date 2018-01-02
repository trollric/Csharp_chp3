using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;
        public string name;

        // Put back the defautl constructor.
        public Motorcycle() {
            Console.WriteLine("In default ctor");
        }

        // Our custom constructor
        public Motorcycle(int powerLevel) : this(powerLevel, ""){
            Console.WriteLine("I only took an int");
        }
        public Motorcycle(string name) : this(0, name) {
            Console.WriteLine("I only took a string");
        }
        public Motorcycle(int powerLevel, string name)
        {
            if (powerLevel > 9000)
            {
                powerLevel = 9000;
            }
            driverIntensity = powerLevel;
            this.name = name;
            Console.WriteLine("I am the master of constructors");
        }

        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("My name is {1} and I say YEEEEEEEEE HAAAAAAAEEEEWW! for the {0}th time",i+1,name);
            }
            
        }

        public void SetDriversName(string name)
        {
            this.name = name;
        }
        
    }
}
