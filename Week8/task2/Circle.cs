using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Circle
    {
        protected double Radius;
        protected string Color;

        public Circle() { }

        public Circle(double radius)
        {
            Radius = radius;

        }
        public Circle(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }
        public void setRadius (double radius)
        {
            this.Radius = radius;
        }
        public void setColor (string color)
        {
            this.Color = color;
        }
        public double getRadius()
        {
            return this.Radius;
        }
        public string getColor()
        {
            return this.Color;
        }
        public double GetArea()
        {
            return 3.14 * this.Radius * this.Radius;
        }
    }
}
