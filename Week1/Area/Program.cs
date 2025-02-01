using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float length;
            float area;
            string str;
            Console.Write("Enter Length: ");
            str = Console.ReadLine();
            length = float.Parse(str);
            area = length * length;
            Console.Write("Area is: ");
            Console.Write(area);
            Console.ReadKey();


        }
    }
}
