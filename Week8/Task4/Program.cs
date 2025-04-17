using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            studentaccount a = null;
            while (true)
            {
                Console.WriteLine("Enter one of the option: ");
                Console.WriteLine("1.create account");
                Console.WriteLine("2.Deposit amount");
                Console.WriteLine("3.Withdraw amount");
                Console.WriteLine("Your option...");
                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.WriteLine("Enter acount title: ");
                    string title = Console.ReadLine();
                    Console.WriteLine("Enter Acount number: ");
                    string number = Console.ReadLine();
                    Console.WriteLine("Enter Balance: ");
                    double balance = double.Parse(Console.ReadLine());
                    a = new studentaccount(title, number, balance);
                    Console.WriteLine(a.ViewDetails());

                }
                if (option == 2)
                {
                    Console.WriteLine("Enter money you want to deposit: ");
                    double money = int.Parse(Console.ReadLine());
                    a.credit(money);


                }
                if (option == 3)
                {
                    Console.WriteLine("Enter money you want to withdraw: ");
                    double withdraw = int.Parse(Console.ReadLine());
                    a.Withdraw(withdraw);


                }
               
            }
           
        }
    }
}
