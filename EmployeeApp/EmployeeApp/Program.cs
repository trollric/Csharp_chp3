using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Name = "Gregory";
            emp.DisplayStats();
            Console.WriteLine();
            Employee empy = new Employee("Marvin", 456, 30000);
            empy.GiveBonus(1000);
            empy.DisplayStats();
            empy.Name = "Marv";
            Console.WriteLine("After we changed the employees name it became: {0}", empy.Name);
            Employee xena = new Employee();
            // This will throw an error
            // since it's longer than 15
            // characters.
            xena.Name ="XENA THE WARRIOR PRINCESS";
            Console.ReadLine();
        }
    }
}
