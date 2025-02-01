using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task5
{
    public class Product
    {
        public string Product_ID;
        public string Product_Name;
        public int    Product_Price;
        public string Product_Catogery;
        public string Product_brandName;
        public string Product_Country;

        private static List<Product> productList = new List<Product>();
        public Product(string productId, string name, int price, string catogery, string brandName, string country)
        {
            Product_ID = productId;
            Product_Name = name;
            Product_Price = price;
            Product_Catogery = catogery;
            Product_brandName = brandName;
            Product_Country = country;     
            
        }

        public string AddProduct()
        {
            productList.Add(this);
            return ("Your Product is SuccessFully added");
        }

        public static void ShowProduct()
        {
            if(productList.Count == 0)
            {
                Console.WriteLine("No Product add yet");
                return;
            }
            Console.WriteLine("All Added Products are:  ");
            foreach (Product product in productList )
            {
                
                Console.WriteLine($"Product ID:  {product.Product_ID}  Name: {product.Product_Name}  Price: {product.Product_Price}  Catogery: {product.Product_Catogery}  Brand Name: {product.Product_brandName}  Country: {product.Product_Country} ");
                
            }
            Console.WriteLine(" ");
        }
        public static double TotalWorth()
        {
            int sum = 0;
            foreach(Product product in productList )
            {
                sum = sum  +  product.Product_Price;
            }
            return sum;
        }
    }
}
