using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            Console.WriteLine("Enter Number 1: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            calculator c = new calculator( number1 , number2);

            int Add = c.add();
            Console.WriteLine($"Answer of Addition is: {Add}");
            int multiply = c.mul();
            Console.WriteLine($"Answer of Multiplication is: {multiply}");
            int divide = c.div();
            Console.WriteLine($"Answer of division is: {divide}");
            int subtract = c.sub();
            Console.WriteLine($"Answer of subtraction is: {subtract}");
        }
    }
}
