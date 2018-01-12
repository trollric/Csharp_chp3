using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    // Rememver that Person extends object
    class Person
    {
        public string Name { get; set; } = "";
        public string Surname { get; set; } = "";
        public int Age { get; set; }
        public string SSN { get; set; } = "1992-11-23-4586";

        public Person()
        {

        }
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public override string ToString()
        {
            string myState;
            myState = string.Format("[Name: {0}; Surname: {1}; Age: {2}]", Name, Surname, Age);
            return myState;
        }

        public override bool Equals(object obj)
        {
            //if(obj is Person && obj != null)
            //{
            //    Person temp = (Person)obj;
            //    if(temp.Name == this.Name && temp.Surname == this.Surname && temp.Age == this.Age)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            //return false;
            return obj.ToString() == this.ToString();
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
