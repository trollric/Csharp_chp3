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
            Console.WriteLine("******Fun with Generic Collections******\n");
            UseGenericList();
            UseGenericStack();
            UseGenericQueue();
            UseSortedSet();
            Console.ReadLine();
        }

        private static void UseSortedSet()
        {
            SortedSet<Person> setOfPeople = new SortedSet<Person>(new SortPeopleByAge())
            {
                new Person("Lightning", "McQueen", 4),
                new Person{FirstName = "Minty", LastName = "Snowman", Age = 18},
                new Person("Gerge","RabbiTeller", 29),
                new Person{ FirstName = "Martin", Age = 14, LastName = "McFly"}
            };
            // Please note that items are sorted by age!
            foreach (Person p in setOfPeople)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();
        }

        private static void UseGenericQueue()
        {
            // Make a Queue with three people.
            Queue<Person> peopleQ = new Queue<Person>();
            peopleQ.Enqueue(new Person("Mary", "Popins", 42));
            peopleQ.Enqueue(new Person("Ash", "Catchem", 10));
            peopleQ.Enqueue(new Person("James", "Carpenter", 54));
            // Peek at the first person in Q.
            Console.WriteLine("{0} is first in line!",peopleQ.Peek().FirstName);
            // Remove the people in the queue.
            GetCoffe(peopleQ.Dequeue());
            GetCoffe(peopleQ.Dequeue());
            GetCoffe(peopleQ.Dequeue());
            // Try to de-q again form Q.
            try
            {
                GetCoffe(peopleQ.Dequeue());
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
        }

        private static void GetCoffe(Person p)
        {
            Console.WriteLine("{0} got a coffee!", p.FirstName);
        }

        private static void UseGenericStack()
        {
            Stack<Person> stackOfPeople = new Stack<Person>();
            stackOfPeople.Push(new Person("James", "Moriarty", 37));
            stackOfPeople.Push(new Person { FirstName = "Greg", LastName = "Flyer", Age = 18 });
            stackOfPeople.Push(new Person("Lilly", "Potter", 48));
            // Now look at the top item, pop it, and look again.
            Console.WriteLine("First person is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Lets use Pop to get and remove {0}",stackOfPeople.Pop());
            Console.WriteLine("\nNow the first person is {0}", stackOfPeople.Peek());
            Console.WriteLine("Lets use Pop to get and remove {0}", stackOfPeople.Pop());
            Console.WriteLine("\nNow the first person is {0}", stackOfPeople.Peek());
            Console.WriteLine("Lets use Pop to get and remove {0}", stackOfPeople.Pop());
            // Now the Stack is empty
            try
            {
                Console.WriteLine("\nFirst person is: {0}",stackOfPeople.Peek());
                Console.WriteLine("Lets use Pop to get and remove {0}", stackOfPeople.Pop());
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine("\nError! {0}",e.Message);
            }
            Console.WriteLine();
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
