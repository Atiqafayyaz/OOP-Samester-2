using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            string str;
            Console.Write("Enter a Number: ");
            str = Console.ReadLine();
            num = int.Parse(str);
            if (num > 50)
            {
                Console.WriteLine("You are Passed");
            }
            else
            {
                Console.WriteLine("You are Failed");
            }
        }
    }
}
