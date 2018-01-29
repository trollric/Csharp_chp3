using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssuesWithNonGenericCollections
{
    class PersonCollection : IEnumerable
    {
        private ArrayList arPeople = new ArrayList();
        public int Count
        {
            get
            {
                return arPeople.Count;
            }
        }
        // Cast for caller.
        public Person GetPerson(int pos)
        {
            return (Person)arPeople[pos];
        }
        public void AddPerson(Person p)
        {
            arPeople.Add(p);
        }
        public void Clearpeople()
        {
            arPeople.Clear();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return arPeople.GetEnumerator();
        }
    }
}
