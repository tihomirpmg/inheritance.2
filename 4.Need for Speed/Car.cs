using System;
using System.Collections.Generic;
using System.Text;

namespace _4.Need_for_Speed
{
    class Car : Vehicle
    {
        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {  
            DefaultFuelConsumption = 3.00;
        }
    }
}
