using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace projectTwo.accessModifier
{

    //parent class
    public class BankAccount
    {
        public double accountNumber;
        protected string accountHolder;
        private double balance;

        public BankAccount(double accountNumber, string accountHolder, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = balance;
        }
        public double AccessBalance()
        {
            return balance;
        }
        public void SetBalance(double balanceAmount)
        {
            balance = balanceAmount;
        }

    }

    //child class
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(double accountNumber, string accountHolder, double balance) : base(accountNumber, accountHolder, balance) { }

        public void ShowDetails()
        {
            Console.WriteLine("--Account Holder Details--");
            Console.WriteLine("Account number : " + accountNumber);
            Console.WriteLine("Account Holder : " + accountHolder);
        }
    }

    public class BankAccountManagement
    {
        //MAIN METHOD
        static void Main(string[] args)
        {
            SavingsAccount savingsAccount = new SavingsAccount(2215001466, "Rishita", 5000);
        }

    }
}
