using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter SeatHeight: ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Speed: ");
            int speed = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Cadence: ");
            int cadence = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Gear: ");
            int gear = int.Parse(Console.ReadLine());

            MountainBike mountainBike = new MountainBike(height , speed, cadence, gear);
            Console.WriteLine("Again Enter height for setter function: ");
            int setheight = int.Parse(Console.ReadLine());
            mountainBike.setSeatHeight(setheight);
            Console.WriteLine("Seat Height:" + mountainBike.GetSeatHeight());
            Console.WriteLine("Enter amount of speed for Decriment: ");
            int dec = int.Parse(Console.ReadLine());
            mountainBike.ApplyBreak(dec);
            Console.WriteLine("Speed After Decriment: " + mountainBike.getspeed());
            Console.WriteLine("Enter Amount of speed for increment: ");
            int inc = int.Parse(Console.ReadLine());
            mountainBike.SpeedUp(inc);
            Console.WriteLine("Speed After Increment: " + mountainBike.getspeed());




        }
    }
}
