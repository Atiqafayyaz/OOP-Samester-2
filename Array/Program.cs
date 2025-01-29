using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            for(int i = 0;  i < 3; i++)
            {
                Console.WriteLine("Enter Number: {0}", i+1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            int largest = -1;
            for(int i = 0; i < 3; i++)
            {
                if (arr[i] > largest)
                {
                    largest = arr[i];
                }
            }
            Console.WriteLine("Largest Number is: {0}", largest);
        }
    }
}
