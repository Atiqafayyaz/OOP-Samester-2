using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class person
    {
        protected string name;
        protected string address;
        public person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public string getName()
        {
            return name;
        }
        public string getAddress()
        {
            return address;
        }
        public void setAddress(string address)
        {
            address = address;
        }
        public string toString()
        {
            string result = $"Person [name={name} , address={address}]";
            return result;
        }
    }
}
