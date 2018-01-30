using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            UseGenericList();
            Console.ReadLine();
        }

        private static void UseGenericList()
        {
            // Make a List of Person objects, filled with
            // collection/object init syntax.
            List<Person> people = new List<Person>()
            {
                new Person{FirstName = "Homer", LastName = "Simpson",Age = 47},
                new Person{FirstName = "Marge", LastName = "Simpson",Age = 45},
                new Person{FirstName = "Lisa", LastName = "Simpson",Age = 9},
                new Person{FirstName = "Bart", LastName = "Simpson",Age = 8}
            };
            // Print out # of items in the list
            Console.WriteLine("Items in the list: {0}", people.Count);
            // Enumeraate over the list.
            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }
            // Insert a new Person
            Console.WriteLine("\n->Inserting a new person.");
            people.Insert(2, new Person("Maggie", "Simpson", 2));
            Console.WriteLine("Items i nthe list: {0}",people.Count);
            // Copy data into a new array.
            Person[] arrayOfPeople = people.ToArray();
            for (int i = 0; i < arrayOfPeople.Length; i++)
            {
                Console.WriteLine("First Names: {0}", arrayOfPeople[i].FirstName);
            }
            Console.WriteLine();
        }
    }
}
