using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            string str;
            int sum = 0;
            Console.WriteLine("Enter Number: ");
            str = Console.ReadLine();
            num = int.Parse(str);
            while (num != -1)
            {
                sum = sum + num;
                Console.WriteLine("Enter Number: ");
                num = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("Sum is: ");
            Console.Write(sum);

        }
    }
}
