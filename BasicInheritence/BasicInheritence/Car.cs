using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritence
{
    class Car
    {
        public readonly int maxSpeed;
        private int currSpeed;

        public int Speed
        {
            get { return currSpeed; }
            set
            {
                currSpeed = value;
                if(currSpeed > maxSpeed)
                {
                    currSpeed = maxSpeed;
                }
            }
        }


        public Car(int maxSpeed)
        {
            this.maxSpeed = maxSpeed;
        }

        public Car()
        {
            maxSpeed = 55;
        }
    }
}
