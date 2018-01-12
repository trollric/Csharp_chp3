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
            SalesPerson fred = new SalesPerson() { Age = 31, Name = "Fred", SalesNumber = 50, Pay = 6000 };
            Manager chucky = new Manager("Chucky", 45, 1497, 102450, "1678-05-04", 9000);
            double cost = chucky.GetBenefitCost();
            Employee.BenefitPackage.BenefitPackageLevel myBenefitlevel = Employee.BenefitPackage.BenefitPackageLevel.Platinum;
            chucky.DisplayStats();
            chucky.GiveBonus(300);
            chucky.DisplayStats();
            Console.WriteLine();
            fred.DisplayStats();
            fred.GiveBonus(150);
            fred.DisplayStats();
            Console.WriteLine();

            CastingExamples();
            Hexagon hex;
            object frank = new Manager();
            try
            {
                hex = (Hexagon)frank;
            }
            catch(Exception e)
            {
                ConsoleColor prevCol = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ForegroundColor = prevCol;
            }

            TestAsKeyword();
            Console.ReadLine();
        }

        private static void TestAsKeyword()
        {
            object[] things = new object[4];
            things[0] = new Hexagon();
            things[1] = false;
            things[2] = new Manager();
            things[3] = "Last thing";

            foreach (object item in things)
            {
                Hexagon h = item as Hexagon;
                if(h == null)
                {
                    Console.WriteLine("This item is not a hexagon");
                }
                else
                {
                    h.Draw();
                }
            }
        }

        static void CastingExamples()
        {
            // A Manager "is-a" System.Object, so we can
            // store a Manager reference in an object variable just fine.
            object frank = new Manager("Frank Zappa", 9, 3012, 40000, "1978-06-27-4572", 5);
            Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "1897-04-13-5167", 1);
            SalesPerson jill = new PTSalesPerson("Jill", 834, 3002, 100000, "2017-06-2673", 90);
            GivePromotion(moonUnit);
            GivePromotion(jill);
            // To promote frank we need to use an explicit class.
            GivePromotion((Manager)frank);

        }

        static void GivePromotion(Employee emp)
        {
            // Increase pay...
            // Give new parking pace in company garage...
            Console.WriteLine("{0} was promoted!",emp.Name);
            if(emp is SalesPerson)
            {
                Console.WriteLine("{0} made {1} sale(s)!",emp.Name, ((SalesPerson)emp).SalesNumber);
                Console.WriteLine();
            }
            if(emp is Manager)
            {
                Console.WriteLine("{0} had {1} stock option(s)!",emp.Name, ((Manager)emp).StockOptions);
                Console.WriteLine();
            }
        }
    }
}
