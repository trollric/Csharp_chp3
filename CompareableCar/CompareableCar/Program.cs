﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareableCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Fun with Object Sorting ******\n");
            // Make an array of Car objects.
            Car[] myAutos = new Car[5];
            myAutos[0] = new Car("Rusty", 80, 1);
            myAutos[1] = new Car("Mary", 40, 234);
            myAutos[2] = new Car("Viper", 40, 34);
            myAutos[3] = new Car("Mel", 40, 4);
            myAutos[4] = new Car("Chucky", 40, 5);
            Console.WriteLine("Before sort");
            foreach(Car c in myAutos)
            {
                Console.WriteLine(c.ToString());
            }
            Console.WriteLine("\nAfter sort");
            Array.Sort(myAutos);
            foreach (Car c in myAutos)
            {
                Console.WriteLine(c.ToString());
            }
            Console.WriteLine("\nNow lets sort my PetName");
            Array.Sort(myAutos, Car.SortByPetName);
            foreach (Car c in myAutos)
            {
                Console.WriteLine(c.ToString());
            }
            Console.ReadLine();
        }
    }
}
