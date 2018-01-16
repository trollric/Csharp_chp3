using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Simple Exception Example ******");
            Console.WriteLine("=> Creating a car and stepping on it!");
            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);
            try
            {
                for (int i = 0; i < 20; i++)
                {
                    myCar.Accelerate(10);
                }
            }
            catch(Exception e)
            {                
                Console.WriteLine("\n*** Error! ***");
                Console.WriteLine("Help to get at: {0}", e.HelpLink);
                Console.WriteLine("\nStack: {0}\n", e.StackTrace);
                Console.WriteLine("->Custom Data:");
                foreach (DictionaryEntry de in e.Data)
                {
                    Console.WriteLine("-> {0}: {1}",de.Key,de.Value);
                }
                Console.WriteLine("Member name: {0}", e.TargetSite);
                Console.WriteLine("Class defining member: {0}", e.TargetSite.DeclaringType);
                Console.WriteLine("Method: {0}",e.TargetSite);
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);
            }
            // The Error has been handled, processing continues with the next statement
            Console.WriteLine("\n***** Out of Exeption logic *****");
            
            Console.ReadLine();
        }
    }
}
