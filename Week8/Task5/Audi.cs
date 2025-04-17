using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Audi:Car
    {
        private double fuelRatePer ;

        public Audi(string color, string model, double price) : base(color, model, price)
        {
          
        }

        public double GetFuelRate()
        {
            return fuelRatePer;
        }
        public void SetFuelRate(double value)
        {
            fuelRatePer = value;
        }

        public void EstimateFuelUsage(double distance)
        {
            double fuelUsed = (fuelRatePer / 100) * distance;
            Console.WriteLine($"Audi will consume {fuelUsed} liters for {distance} km.");
        }
    }
}

