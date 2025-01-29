using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age, toyPrice ;
            int sum = 0;
            float machinePrice;
            string str;
            Console.WriteLine("Enter Your Age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Price Of Washing Machine: ");
            str = Console.ReadLine();
            machinePrice = float.Parse(str);
            Console.WriteLine("Enter Price of Toy: ");
            toyPrice = Convert.ToInt32(Console.ReadLine());
            SumMoney( age,toyPrice, machinePrice , ref sum);
            TotalMoney(toyPrice, machinePrice, ref sum);



        }
        static void SumMoney(int age , int toyPrice , float machinePrice , ref int sum)
        {
            int even = 0;
            int odd = 0; 
             for(int i = 1; i <= age; i++)
            {
              if(i % 2 == 0)
                {
                    even = even + ((i / 2) * 10 - 1);
                }
              else if (i % 2 != 0)
                {
                    odd = odd + toyPrice;
                }
            }
            sum = even + odd;
   
        }
        static void TotalMoney(int toyPrice, float machinePrice, ref int sum)
        {
            float remain;
          
            if(sum > machinePrice)
            {
                remain = sum - machinePrice;
                Console.WriteLine("Yes");
                Console.WriteLine(remain);

            }
            else if(sum < machinePrice)
            {
                remain = machinePrice - sum;
                Console.WriteLine("No");
                Console.WriteLine(remain);
            }

        }
    }
}
