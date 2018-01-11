using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape
    {
        // Properties
        public string PetName { get; set; }

        // Constructors
        public Shape(string name = "No name")
        {
            PetName = name;
        }

        // Methods
        public virtual void Draw()
        {
            Console.WriteLine("Inside Shape.Draw()");
        }
    }
}
