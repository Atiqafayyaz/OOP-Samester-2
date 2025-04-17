using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class studentaccount:Account
    {
        protected double creditLimit = 500000;

        public studentaccount(string title, string accountNO, double balance) : base(title, accountNO, balance)
        {

            this.title = title;
            this.accno = accountNO;
            this.balance = balance;
        }
       
        public  override void credit(double amount)
        {
            if (balance + amount > creditLimit)
            {
                Console.WriteLine("Cannot credit  Credit Limit exceeded ");
            }
            else
            {
                base.credit(amount);
            }
        }
    }
}

