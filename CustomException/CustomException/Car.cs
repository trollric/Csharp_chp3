using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class Car
    {
        public const int MaxSpeed = 100;
        public int CurrSpeed { get; set; }
        public string PetName { get; set; }

        private bool carIsDead;
        private Radio theMusicBox = new Radio();

        public Car()
        {

        }
        
        public Car(string name, int speed)
        {
            PetName = name;
            CurrSpeed = speed;
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
                    CarIsDeadException ex = new CarIsDeadException(string.Format("{0} has overheated!", PetName), "You have a lead foot", DateTime.Now);
                    ex.HelpLink = "www.google.com";
                    throw ex;
                }
                else
                    Console.WriteLine("=> CurrSpeed = {0}", CurrSpeed);
            }
        }
    }
}
