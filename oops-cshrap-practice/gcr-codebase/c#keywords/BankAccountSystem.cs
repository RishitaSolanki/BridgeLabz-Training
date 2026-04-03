using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.Keywords
{
    //bankaccount class
    public class BankAccount
    {

        public static string bankName = "Union Bank";
        private static int totalAccounts = 0;
        public readonly long AccountNumber;
        public string AccountHolderName;

        //parameterized Constructor
        public BankAccount(string enterAccountHolderName, long enterAccountNumber)
        {
            this.AccountHolderName = enterAccountHolderName;
            this.AccountNumber = enterAccountNumber;
            totalAccounts++;
        }


        public static int GetTotalAccounts()
        {
            return totalAccounts;
        }


        public void ShowAccountDetails(object account)
        {


            if (account is BankAccount)
            {
                Console.WriteLine("Bank Name        : " + bankName);

                Console.WriteLine("Account Holder Name   : " + AccountHolderName);

                Console.WriteLine("Account Number   : " + AccountNumber);
            }


            else
            {
                Console.WriteLine("Invalid account ");
            }

        }
    }



    //MAIN CLASS
    class BankAccountSystem
    {
        //MAIN METHOD
        public static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount("Rishita", 2215001466);
            BankAccount account2 = new BankAccount("Monty", 2215001099);

            account1.ShowAccountDetails(account1);
            Console.WriteLine();

            account2.ShowAccountDetails(account2);
            Console.WriteLine();

            Console.WriteLine("Total Accounts: " + BankAccount.GetTotalAccounts());

        }
    }
}
