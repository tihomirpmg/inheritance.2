using System;
using System.Collections.Generic;
using System.Text;

namespace _4.Need_for_Speed
{
    class Vehicle
    {
        private int horsePower;
        private double fuel;
        private double fuelConsumption;
        private double defaultFuelConsumption;
        private double kilometers;
        protected virtual double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set
            {
                this.fuelConsumption = defaultFuelConsumption*kilometers; ;
            }
        }
        public double DefaultFuelConsumption
        {
            get { return this.defaultFuelConsumption; }
            set
            {
                this.defaultFuelConsumption = value;
            }
        }
        public int HorsePower
        {
            get { return this.horsePower; }
            set
            {
                this.horsePower = value;
            }
        }
        public double Fuel
        {
            get { return this.fuel; }
            set
            {
                this.fuel = value;
            }
        }
        public double Kilometers
        {
            get { return this.kilometers; }
            set
            {
                this.kilometers = 100;
            }
        }

        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }
          
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Horse power:{this.horsePower} Fuel:{this.fuel} FuelLeft:{fuel-(defaultFuelConsumption*kilometers)/100} DefFuelCons:{this.defaultFuelConsumption} Distance:{this.kilometers}");
            return sb.ToString();
        }
    }
}
