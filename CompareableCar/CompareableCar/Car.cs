using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareableCar
{
    class Car : IComparable
    {
        public const int MaxSpeed = 100;
        public int CurrSpeed { get; set; }
        public string PetName { get; set; }
        public int CarID { get; set; }
        private bool carIsDead;
        private Radio theMusicBox = new Radio();
        public static IComparer SortByPetName {
            get
            {
                return (IComparer)new PetNameComparer();
            }
        }

        public Car()
        {

        }
        
        public Car(string name, int speed, int id)
        {
            PetName = name;
            CurrSpeed = speed;
            CarID = id;
        }

        public void CrankTunes(bool state)
        {
            // delegate request to the inner Radio class
            theMusicBox.TurnOn(state);
        }
        public void Accelerate(int delta)
        {
            if (carIsDead)
                Console.WriteLine("{0} is out of order due to an exploded engine...",PetName);
            else
            {
                CurrSpeed += delta;
                if(CurrSpeed >= MaxSpeed)
                {
                    CurrSpeed = 0;
                    carIsDead = true;
                    // Use the throw keyword to raise an exception.
                    Exception ex = new Exception(string.Format("{0} has overheated! T.T", PetName));
                    ex.HelpLink = "http://www.CarsRUs.com";
                    ex.Data.Add("Timestamp",string.Format("The car exoloded at {0}", DateTime.Now));
                    ex.Data.Add("Cause", "You have a lead foot");
                    throw ex;
                }
                else
                    Console.WriteLine("=> CurrSpeed = {0}", CurrSpeed);
            }
        }

        public override string ToString()
        {
            string message;
            message = String.Format("Name: {0}\nCurrent speed: {1}\nID: {2}", PetName, CurrSpeed, CarID);
            return message;
        }

        public int CompareTo(object obj)
        {
            Car temp = obj as Car;
            if(temp != null)
            {
                if (this.CarID > temp.CarID)
                    return 1;
                if (this.CarID < temp.CarID)
                    return -1;
                else
                    return 0;
            }
            else
            {
                throw new ArgumentException("Parameter is not a Car!");
            }
        }
    }
}
