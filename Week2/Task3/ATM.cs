using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class ATM
    {
        public double total_balance;

        List<string> transection = new List<string>();
      


        public void deposit(double deposit)
        {

            total_balance = total_balance + deposit;
            Console.WriteLine("Your money has been Deposited.");
            transection.Add ("Deposit:" + deposit);
        }
        public void withdraw(double withdraw)
        {
            if (total_balance < withdraw)
            {
                Console.WriteLine("Your Balance is low");
                return;
            }
            total_balance = total_balance - withdraw;
            Console.WriteLine("Your money has been withdrawn.");
            transection.Add("Withdraw:" + withdraw);

        }
        public void ShowBalance()
        {
            Console.WriteLine("Your Balance is: " + total_balance);
        }
        public void transectionHistory()
        {
            if (transection.Count == 0)
            {
                Console.WriteLine("No transection yet");
                return;
            }
            foreach (string transection in transection)
            {
                Console.WriteLine(transection);
            }
        }
       
        
    }
}
