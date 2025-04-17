using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Bmw:Car
    {

        private double fuelEfficiency;

        public Bmw(string color,string model, double price) : base(color,model,price)
        {
            
        }

        public double GetFuelEfficiency()
        {
            return fuelEfficiency;
        }
        public void SetFuelEfficiency(double value)
        {
            this.fuelEfficiency = value;
        }

        public void CalculateFuel(double distance)
        {
            double fuelNeeded = distance / fuelEfficiency;
            Console.WriteLine($"BMW requires {fuelNeeded} liters of fuel for {distance} km.");
        }
    }
}

