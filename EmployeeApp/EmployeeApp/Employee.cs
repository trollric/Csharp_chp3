﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {
        // Field data.
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;

        // Properties
        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }
        public string Name
        {
            get
            {
                return empName;
            }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name length exceedes 15 characters!");
                }
                else
                {
                    empName = value;
                }
            }
        }
        public int ID {
            get { return empID; }
            set { empID = value; }
        }
        public float Pay {
            get { return currPay; }
            set { currPay = value; }
        }

        // Constructors
        public Employee() { }

        public Employee(string name, int id, float pay) : this(name, 0, id, pay) { }

        public Employee(string name, int age, int id, float pay)
        {
            Name = name;
            ID = id;
            Age = age;
            Pay = pay;
        }

        // Methods.

        public void GiveBonus(float amount)
        {
            Pay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Age: {0}",Age);
            Console.WriteLine("Pay: {0}", Pay);
        }
    }
}
