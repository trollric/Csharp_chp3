using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClonableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** A first look at Interfaces ******\n");
            // All of these classes support the IClonable interface.
            string myStr = "Hello";
            OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());
            System.Data.SqlClient.SqlConnection sqlCnn = new System.Data.SqlClient.SqlConnection();
            // Therefore, they can all be passed into a method taking IClonable
            CloneMe(myStr);
            CloneMe(unixOS);
            CloneMe(sqlCnn);
            Console.ReadLine();
        }

        private static void CloneMe(ICloneable obj)
        {
            // Clone whatever we get and print out the name.
            object theClone = obj.Clone();
            Console.WriteLine("Your clone is a: {0}",theClone.GetType().Name);
        }
    }
}
