using System;
using System.Collections.Generic;
using System.Text;

namespace _4.Need_for_Speed
{
    class FamilyCar : Car
    {
        public FamilyCar(int horsePower, double fuel) : base(horsePower, fuel)  
        {
            Kilometers = 100;
        }
    }
}
