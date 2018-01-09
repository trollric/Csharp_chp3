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
            Console.ReadLine();
        }
    }
}
