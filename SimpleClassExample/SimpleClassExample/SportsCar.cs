using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class SportsCar
    {
        private int speed;
        private string name;

        public SportsCar(string name= "default", int speed = 10)
        {
            this.name = name;
            this.speed = speed;
        }

        public void Display()
        {
            Console.WriteLine("Name is: {0} and current speed is {1}\n",name, speed);
        }

        public void SpeedUp(int inc_speed)
        {
            speed += Math.Abs(inc_speed);
        }

        public void SpeedDown(int dec_speed)
        {
            speed -= Math.Abs(dec_speed);
        }
    }
}
