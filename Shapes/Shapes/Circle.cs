using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : Shape
    {
        public Circle(){}
        public Circle(string name) : base(name){}

        public override void Draw()
        {
            Console.WriteLine("This circle is called {0}",PetName);
        }

        // Circle does not override Draw()
    }
}
