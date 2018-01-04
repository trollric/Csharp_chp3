using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Fun with Static Data ******\n");
            SavingsAccount s1 = new SavingsAccount(50);
            SavingsAccount s2 = new SavingsAccount(100);
            // Print current interest rate
            Console.WriteLine("The current intrest is {0}", SavingsAccount.GetIntrestRate());
            // Change the intrest rate
            SavingsAccount.SetIntrestRate(0.05);
            SavingsAccount s3 = new SavingsAccount(10000.75);
            // After we make a new instance of SavingsAccount the static is not "reset"
            Console.WriteLine("The current intrest is {0}", SavingsAccount.GetIntrestRate());
            
            Console.ReadLine();
        }
    }
}
