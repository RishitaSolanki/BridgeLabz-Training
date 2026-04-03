using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.oops.BankingSystem
{
    public class BankingSystemMain
    {
        //MAIN METHOD
        public static void Main(string[] args)
        {
            BankAccount[] accounts = new BankAccount[1];

            for (int i = 0; i < accounts.Length; i++)
            {
                Console.WriteLine("Enter your account number : ");
                long accountNumber = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine("Enter your Name ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter your balance : ");
                double balance = Convert.ToDouble(Console.ReadLine());

                accounts[i] = new SavingsAccount(accountNumber, name, balance);
            }



            foreach (BankAccount account in accounts)
            {
                Console.WriteLine("Balance: " + account.GetBalance());

                Console.WriteLine("Interest: " + account.CalculateInterest());

                if (account is Iloanable loanAccount)
                {
                    loanAccount.ApplyForLoan();
                    Console.WriteLine("Loan Eligible: " +
                        loanAccount.CalculateLoanEligibility(100000));
                }
            }
        }
    }
}
