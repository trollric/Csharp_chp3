﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Manager : Employee
    {
        public int StockOptions { get; set; }

        public Manager()
        {

        }
        public Manager(string fullName, int age, int empID, float currPay, string ssn, int numbOfOpt) : base(fullName, age, empID, currPay, ssn)
        {
            StockOptions = numbOfOpt;
        }

        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            StockOptions += r.Next(500);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of stock optiopns: {0}\n",StockOptions);
        }
    }
}
