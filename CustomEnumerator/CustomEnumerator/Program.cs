using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Fun with IEnumerable / IEnumerator ******\n");
            Garage carLot = new Garage();
            // Hand over each car in the collection?
            foreach(Car c in carLot)
            {
                Console.WriteLine("{0} is going {1} KMH",c.PetName,c.CurrSpeed);
            }
            Console.ReadLine();
        }
    }
}
