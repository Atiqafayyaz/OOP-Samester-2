using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Car
    {
        private string model;
        private string color;
        private double price;

        public Car(string color, string model, double price)
        {
            this.model = model;
            this.color = color;
            this.price = price;
        }

        public string GetModel()
        {
            return model;
        }
        public string GetColor()
        {
            return color;
        }
        public double GetPrice()
        {
            return price;
        }

        public void SetModel(string model)
        {
            this.model = model;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public void SetPrice(double price)
        {
            this.price = price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Model :{model},Color Of Car {color},Price of Car {price}");
        }
    }
}

