using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Cylinder : Circle
    {
        private double height;

        public Cylinder()
        {
            
        }
        public Cylinder(double radius) : base (radius) 
        {
            
        }
        public Cylinder(double radius,double height)
        {

        }
        public Cylinder(double radius,double height , string color) : base (radius,color) 
        {

        }

        public void setHeight(double height)
        {
            this.height = height;
        }
        public double getHeight()
        {
            return this.height;
        }
        public double getvolume()
        {
            return 3.14 * Radius * Radius * height;
        }
    }
}
