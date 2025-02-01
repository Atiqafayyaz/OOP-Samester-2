using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           product product = new product();
            product.transectionID = 1;
            product.productName = "soap";
            product.Amount = 1;
            product.date = "29 january";
            product.time = "7 o'clock";

            product product1 = product;
            product1.transectionID = 3;
            product1.productName = "surf";
            product1.Amount = 3;
            product1.date = "29 fabrary";
            product1.time = "9 o'clock";

            Console.WriteLine(product.productName);

        }
    }
}
