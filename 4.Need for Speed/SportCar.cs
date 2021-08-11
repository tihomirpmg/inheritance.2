using System;
using System.Collections.Generic;
using System.Text;

namespace _4.Need_for_Speed
{
    class SportCar : Car
    {
        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
        {
            DefaultFuelConsumption = 10.00;   
            Kilometers = 100;
        }
    }
}
