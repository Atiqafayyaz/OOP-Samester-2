using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string option;
            while (true)
            {
                Console.WriteLine("Enter one of the following option: ");
                Console.WriteLine("1.Add Product");
                Console.WriteLine("2.Show Products");
                Console.WriteLine("3.Total Store Worth");
                Console.WriteLine("Your Option:  ");
                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Enter product ID: ");
                    string productId = Console.ReadLine();

                    Console.WriteLine("Enter Product Name: ");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter Product Price: ");
                    int price = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Product Catogery: ");
                    string catogery = Console.ReadLine();

                    Console.WriteLine("Enter Brand Name: ");
                    string brandName = Console.ReadLine();

                    Console.WriteLine("Enter Country Name: ");
                    string country = Console.ReadLine();

                    Product product = new Product(productId, name, price, catogery, brandName, country);
                    Console.WriteLine(product.AddProduct());

                }
                else if (option == "2")
                {

                    Product.ShowProduct();
                }
                else if (option == "3")
                {
                    Console.WriteLine(Product.TotalWorth());
                }
            }
        }
    }
}
