using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your Address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter Program: ");
            string program = Console.ReadLine();
            Console.WriteLine("Enter Year: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter fee: ");
            int fee = int.Parse(Console.ReadLine());
            student s = new student(name , address,program,year,fee);
            s.setProgram(program);
            Console.WriteLine(s.toString());
            Console.WriteLine(s.getProgram());
        }
    }
}
