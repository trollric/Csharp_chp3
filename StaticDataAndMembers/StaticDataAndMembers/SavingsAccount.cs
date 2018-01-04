using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class SavingsAccount
    {
        // Instance-level data.
        public double currBalance;
        public static double currInterestRate = 0.04;

        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }

        static SavingsAccount()
        {
            Console.WriteLine("In static CTOR");
            currInterestRate = 0.04;
        }

        public static void SetIntrestRate(double newIntrest)
        {
            currInterestRate = newIntrest;
        }

        public static double GetIntrestRate()
        {
            return currInterestRate;
        }
    }
}
