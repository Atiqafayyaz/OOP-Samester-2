using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Account
    {
        protected string title;
        protected string accno;
        protected double balance;
        public Account(string title, string accountNo, double balance)
        {
            this.title = title;
            this.accno = accountNo;
            this.balance = balance;
        }
        public void SetBalance(double balance)
        {
            this.balance = balance;
        }
        public string ViewDetails()
        {
            string result = $"Account Title: {title}      Account no: {accno}    balance:{balance}";
            return result;
        }
        public virtual void credit(double deposit)
        {
            balance = balance + deposit;
            Console.WriteLine("Your current balance: " + balance);
        }
        public void Withdraw(double withdraw)
        {
            balance = balance - withdraw;
            Console.WriteLine("Your current balance: " + balance);
        }
    }
}
