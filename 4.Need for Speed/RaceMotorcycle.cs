using System;
using System.Collections.Generic;
using System.Text;

namespace _4.Need_for_Speed
{
    class RaceMotorcycle : Motorcycle
    {
        public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel) 
        { 
            DefaultFuelConsumption = 8.00;
            Kilometers = 100;
        }
    }
}
