using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.oops.BankingSystem
{
    public abstract class BankAccount
    {
        private long accountNumber;
        private string holderName;
        protected double balance { get; set; }

        //constructor
        protected BankAccount(long ANumber, string HName, double balance)
        {
            this.accountNumber = ANumber;

            this.holderName = HName;

            this.balance = balance;
        }


        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance = balance+amount;
                Console.WriteLine("Amount deposited successfully...");
            }
            else { Console.WriteLine("Sorry...Invalid amount"); }

        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Amount withdrawn successfully...");
            }
            else
            {
                Console.WriteLine("Sorry... valid amount");
            }
        }


        public double GetBalance()
        {
            return balance;
        }



        public abstract double CalculateInterest();
    }
}
