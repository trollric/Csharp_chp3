using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** The Employee Class Hierarchy ******\n");
            SalesPerson fred = new SalesPerson() { Age = 31, Name = "Fred", SalesNumber = 50 };
            Manager chucky = new Manager("Chucky", 45, 1497, 102450, "1678-05-04", 9000);
            double cost = chucky.GetBenefitCost();
            Console.ReadLine();
        }
    }
}
