using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Fun with Custom Generic Methods ******\n");
            // Swap 2 ints
            int a = 10, b = 90;
            Console.WriteLine("Before the swap a = {0}, b = {1}",a,b);
            MyGenericMethods.Swap(ref a, ref b);
            Console.WriteLine("After the swap a = {0}, b = {1}",a,b);
            Console.WriteLine();
            // Swap two strings
            string s1 = "Hello", s2 = "World";
            Console.WriteLine("Before swap it reads: {0} {1}", s1, s2);
            MyGenericMethods.Swap(ref s1, ref s2);
            Console.WriteLine("After swap it reads: {0} {1}", s1, s2);
            // Swap two bool
            bool b1 = true, b2 = false;
            Console.WriteLine("Before swap it reads: {0} {1}", b1, b2);
            MyGenericMethods.Swap<bool>(ref b1, ref b2);
            Console.WriteLine("After swap it reads: {0} {1}", b1, b2);
            MyGenericMethods.DisplayBaseClass<int>();
            MyGenericMethods.DisplayBaseClass<string>();
            // Compiler error must supply base class
            // DisplayBaseClass();
            Console.ReadLine();
        }

    }
}
