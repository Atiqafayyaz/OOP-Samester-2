using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class student:person
    {
        private string program;
        private int year;
        private double fee;
        public student(string name, string address, string pay, int year, double fee) : base(name, address)
        {
            this.name = name;
            this.address = address;
            this.program = pay;
            this.year = year;
            this.fee = fee;
        }
        public string getProgram()
        {
            return program;

        }
        public void setProgram(string program)
        {
            this.program = program;
        }
        public int getYear()
        {
            return year;
        }
        public void setYear(int year)
        {
            this.year = year;
        }
        public double getFee()
        {
            return fee;
        }
        public void setFee(double fee)
        {
            this.fee = fee;
        }
    }
}
