using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task3
{
    public class staff:person
    {
        private string school;
        private double pay;
        public staff(string name, string address, string school, double pay) : base(name, address)
        {
            name = name;
            this.address = address;
            school = school;
            pay = pay;

        }
        public string getSchool()
        {
            return school;
        }
        public void setSchool(string school)
        {
            this.school = school;
        }
        public double getPay()
        {
            return pay;
        }
        public void setPay(double pay)
        {
            this.pay = pay;
        }
    }
}
