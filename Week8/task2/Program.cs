using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Cylinder cylinder = new Cylinder();
            cylinder.setRadius(1.0);
            cylinder.setColor("red");
            cylinder.setHeight(1.0);
            Console.WriteLine("Area or Circle is: " + cylinder.GetArea());
            Console.WriteLine("Color is: " + cylinder.getColor());
            Console.WriteLine("Height of Cylinder is: " + cylinder.getvolume());
        }
    }
}
