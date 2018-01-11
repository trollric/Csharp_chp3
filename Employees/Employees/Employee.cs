using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    partial
    class Employee
    {
        // Nested class
        // Will function as a contained class.
        public class BenefitPackage
        {
            // Assume we have other members that represent
            // Dental/health benefits, and so on.
            public enum BenefitPackageLevel
            {
                Standard, Gold, Platinum
            }

            public double ComputePayDeduction()
            {
                return 125.0;
            }
        }

        // Properties
        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }
        public string Name
        {
            get
            {
                return empName;
            }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name length exceedes 15 characters!");
                }
                else
                {
                    empName = value;
                }
            }
        }
        public int ID {
            get { return empID; }
            set { empID = value; }
        }
        public float Pay {
            get { return currPay; }
            set { currPay = value; }
        }        
        public string SSN
        {
            get { return empSSN; }
        }
        // Expose object through a custom property.
        public BenefitPackage Benefits
        {
            get { return empBenefits; }
            set { empBenefits = value; }
        }
        


        // Methods.

        // Expose certain benefit behaviors of object.
        public double GetBenefitCost()
        {
            return empBenefits.ComputePayDeduction();
        }

        public virtual void GiveBonus(float amount)
        {
            Pay += amount;
        }

        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Age: {0}",Age);
            Console.WriteLine("Pay: {0}", Pay);
        }
    }
}
