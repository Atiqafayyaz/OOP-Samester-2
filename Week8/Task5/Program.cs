using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter one of the following: ");
            Console.WriteLine("1.Calcuate fuel for BMW");
            Console.WriteLine("2.calcuate fuel for audi");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                Console.WriteLine("Enter color: ");
                string color = Console.ReadLine();
                Console.WriteLine("Enter model: ");
                string model = Console.ReadLine();
                Console.WriteLine("Enter price: ");
                double price = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter distance: ");
                double distance = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter fuelRate per 100km: ");
                double fuelrate = double.Parse(Console.ReadLine());
                Bmw bmwCar = new Bmw(color, model, price);
                bmwCar.SetFuelEfficiency(fuelrate);
                bmwCar.DisplayInfo();
                bmwCar.CalculateFuel(distance);
            }
            if (option == 2)

            {
                Console.WriteLine("Enter color: ");
                string color = Console.ReadLine();
                Console.WriteLine("Enter model: ");
                string model = Console.ReadLine();
                Console.WriteLine("Enter price: ");
                double price = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter distance: ");
                double distance = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter fuelRate per 100km: ");
                double fuelrate = double.Parse(Console.ReadLine());
                Audi audiCar = new Audi(color, model, price);
                audiCar.SetFuelRate(fuelrate);
                audiCar.DisplayInfo();
                audiCar.EstimateFuelUsage(distance);
            }
            Console.ReadLine();
        }
    }
}
