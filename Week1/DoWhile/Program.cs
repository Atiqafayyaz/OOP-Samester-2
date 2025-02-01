using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            do
            {
                Console.WriteLine("Enter Number: ");
                num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }
            while (num != -1);
            sum = sum + 1;        //because loop run one times more even we enter -1 so total would be sum -1 thats why we add 1
            Console.WriteLine("Sum is {0}", sum);
            Console.Read();
        }
    }
}
