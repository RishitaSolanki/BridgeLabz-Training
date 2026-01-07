using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.oops.BankingSystem
{
    public class SavingsAccount : BankAccount, Iloanable
    {
        private const double InterestRate = 0.05;

        //constructor
        public SavingsAccount(long accountNumber, string holderName, double balance) : base(accountNumber, holderName, balance) { }
        public override double CalculateInterest()
        {
            return InterestRate * balance;
        }



        public void ApplyForLoan()
        {
            Console.WriteLine("Savings account loan applied.");
        }



        public bool CalculateLoanEligibility(double amount)
        {
            return amount <= balance * 3;
        }
    }
}
