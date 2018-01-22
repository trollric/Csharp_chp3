using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIInterfaceHierarchy
{
    class Square : IShape
    {
        // Using explicit implementation to handle member name clash.

        void IPrintable.Draw()
        {
            Console.WriteLine("Draw to printer...");
        }
        void IDrawable.Draw()
        {
            Console.WriteLine("Draw to the screen...");
        }

        public int GetNumberOfSides()
        {
            return 4;
        }

        public void Print()
        {
            Console.WriteLine("Printing...");
        }
    }
}
