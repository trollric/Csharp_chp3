﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumeratorWithYield
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Fun with the Yield keyword ******\n");
            Garage carLot = new Garage();
            // Get items using GetEnumerator();.
            foreach (Car c in carLot)
            {
                Console.WriteLine("{0} is going at a speed of {1} KMH",c.PetName,c.CurrSpeed);
            }
            Console.WriteLine();
            // Get items (in reverse!) using named iterator
            foreach (Car c in carLot.GetTheCars(true))
            {
                Console.WriteLine("{0} is going at a speed of {1} KMH", c.PetName, c.CurrSpeed);
            }
            Console.ReadLine();
        }
    }
}
