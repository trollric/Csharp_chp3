using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNameClash
{
    class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        // Shared Draw():ing logic
        void IDrawToForm.Draw()
        {
            Console.WriteLine("Drawing to the Form...");
        }
        void IDrawToMemory.Draw()
        {
            Console.WriteLine("Drawing to the Memory...");
        }
        void IDrawToPrinter.Draw()
        {
            Console.WriteLine("Drawing to the Printer...");
        }
    }
}
