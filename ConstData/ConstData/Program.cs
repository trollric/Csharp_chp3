using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstData
{
    class MyMathClass
    {
        public const double PI = 3.1415;
    }

    class MyReadOnlyMathClass
    {
        public readonly double PI;
        public MyReadOnlyMathClass()
        {
            PI = 3.14;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with constants *****\n");
            Console.WriteLine("The value of PI is: {0}",MyMathClass.PI);
            // Error can not change a constant!
            // MyMathClass.PI = 3.1444;

            // Now with a constructor CTOR
            MyReadOnlyMathClass mRO = new MyReadOnlyMathClass();
            Console.WriteLine();
            Console.WriteLine("Value of mRO PI: {0}", mRO.PI);
            Console.ReadLine();
        }
    }
}
