﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    class Garage
    {
        // The hidden int backing field is set to 1!
        public int NumberOfCars { get; set; } = 1;
        // The hidden Car backing field is set to a new car!
        public Car MyAuto { get; set; } = new Car();

        // Must use consctructors to override default
        // values assigned to hidden abcking fields.

        public Garage()
        {
            MyAuto = new Car();
            NumberOfCars = 1;
        }

        public Garage(Car car, int number)
        {
            MyAuto = car;
            NumberOfCars = number;
        }
    }
}
