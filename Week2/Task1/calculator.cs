using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class calculator
    {
        public int x;
        public int y;

        public int add()
        {
            int z = x + y;
            return z;
        }
        public int mul()
        {
            return x * y;
        }
        public int div()
        {
            return x / y;
        }
        public int sub()
        {
            return x - y;
        }
        public calculator(int number1 , int number2)
        {
            x = number1;
            y = number2;
        }
    }
}
