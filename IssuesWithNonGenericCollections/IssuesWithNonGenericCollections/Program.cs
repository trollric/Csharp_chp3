using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssuesWithNonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make a ValueType (int) variable.
            int myInt = 25;
            // Box the Int into an object reference.
            object boxedInt = myInt;
            SimpleUnboxingOperation();
            Console.WriteLine();
            WorkWithArrayList();
            Console.ReadLine();
        }

        private static void WorkWithArrayList()
        {
            // Value types are automatically boxed when
            // passed to a method requesting an object.
            ArrayList myInts = new ArrayList();
            myInts.Add(10);
            myInts.Add(20);
            myInts.Add(35);
            // Unboxing occurs when an object is converted back to
            // stack-based data.
            int i = (int)myInts[0];
            // Now it is reboxed, as WriteLine() requires object types!
            Console.WriteLine("Value of your int: {0}\n", i);
        }

        private static void SimpleUnboxingOperation()
        {
            // Make a ValueType (int) variable.
            int myInt = 25;
            // Box the int into an object reference.
            object boxedInt = myInt;
            // Unbox the reference back into a corresponding int.
            try
            {
                long unboxedLong = (long)boxedInt;
            }
            catch(InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
            //int unboxedInt = (int)boxedInt;
        }
    }
}
