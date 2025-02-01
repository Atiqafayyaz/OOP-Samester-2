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
            int option;
            ATM atm = new ATM();
            atm.total_balance = 500000;
            while (true)
            {
                Console.WriteLine("Enter one of the following option: ");
                Console.WriteLine("1.Deposit");
                Console.WriteLine("2.Withdraw");
                Console.WriteLine("3.Show Balance");
                Console.WriteLine("4.Transaction History");
                Console.WriteLine("5.Exit");
                option = Convert.ToInt32(Console.ReadLine());


                if (option == 1)
                {
                    Console.WriteLine("Enter amount: ");
                    double deposit = Convert.ToDouble(Console.ReadLine());
                    atm.deposit(deposit);
                }
                else if (option == 2)
                {
                    Console.WriteLine("Enter amount: ");
                    double withdraw = Convert.ToDouble(Console.ReadLine());
                    atm.withdraw(withdraw);
                }
                else if (option == 3)
                {
                    atm.ShowBalance();
                }
                else if (option == 4)
                {
                    atm.transectionHistory();
                }
                else if (option == 5)
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
                
            }

            
        }
       
       
    }
}
