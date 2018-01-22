﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNameClash
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Fun with Interface Name Clashes ******\n");
            // All of these invocations call
            // the same Draw() method.
            Octagon oct = new Octagon();
            IDrawToForm itfForm = (IDrawToForm)oct;
            itfForm.Draw();
            IDrawToPrinter itfPrinter = (IDrawToPrinter)oct;
            itfPrinter.Draw();
            IDrawToMemory itfMemory = (IDrawToMemory)oct;
            itfMemory.Draw();
            // We now must use casting to acces the Draw() members.
            Console.WriteLine();
            ((IDrawToPrinter)oct).Draw();
            // Could also use the is keyword
            if(oct is IDrawToMemory)
            {
                ((IDrawToMemory)oct).Draw();
            }
            Console.ReadLine();
        }
    }
}
