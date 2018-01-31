using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithObservableCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make a collection to observe and add a few Person objects.
            ObservableCollection<Person> people = new ObservableCollection<Person>()
            {
                new Person("Eddy","Murphy", 58),
                new Person("Charlie", "Sheen", 60),
                new Person("Lille", "Skutt", 8)
            };
            // Wire up the ColletionChanged event.
            people.CollectionChanged += people_CollectionChanged;
            people.Add(new Person("Handy", "Shoehead", 54));
            Person getLostPerson = people[2];
            people.Remove(getLostPerson);
            Console.ReadLine();
        }

        private static void people_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            // What was the action that caused the event?
            Console.WriteLine("Action for this event: {0}", e.Action);
            // They removed something
            if(e.Action == NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Here are the OLD items:");
                foreach(Person p in e.OldItems)
                {
                    Console.WriteLine(p.ToString());
                }
            }
            // They added something.
            if(e.Action == NotifyCollectionChangedAction.Add)
            {
                // Now show the NEW items that were inserted.
                Console.WriteLine("Here are the NEW items:");
                foreach (Person p in e.NewItems)
                {
                    Console.WriteLine(p.ToString());
                }
            }
            Console.WriteLine();
        }
    }
}
