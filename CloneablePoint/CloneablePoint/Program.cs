﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Fun with Object Cloning ******\n");
            // Two references to the same object.
            Point p1 = new Point(50, 50);
            Point p2 = (Point)p1.Clone();
            p2.X = 0;
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine();
            Console.WriteLine("Created and cloned p3 to a new Point p4");
            Point p3 = new Point(100, 100, "Jane");
            Point p4 = (Point)p3.Clone();
            Console.WriteLine("Before modification:");
            Console.WriteLine("p3: {0}", p3);
            Console.WriteLine("p4: {0}",p4);
            p4.Desc.PetName = "My generic clone";
            p4.X = 9;
            Console.WriteLine("\nChanged p.4desc.petName and p4.X");
            Console.WriteLine("After modification");
            Console.WriteLine("p3: {0}",p3);
            Console.WriteLine("p4: {0}",p4);
            Console.ReadLine();
        }
    }
}
