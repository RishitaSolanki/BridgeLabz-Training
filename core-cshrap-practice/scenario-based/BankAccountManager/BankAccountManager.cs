using System;
using System.Collections.Generic;
using System.Text;

namespace project1.ScenarioBased
{
    class BankAccountManager
    {
        static long accountNumber;
        static string accountHolderName;
        static double totalAmount;
        static int secretPIN;
        static bool isAccountReady = false;
        static bool isPinReady = false;

        
        //Login portal
        static void LoginPortal()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("--LOGIN PORTAL--");

                Console.WriteLine("SELECT ACCESS TYPE:");
                Console.WriteLine("1 : CUSTOMER LOGIN");
                Console.WriteLine("2 : ADMIN LOGIN");
                Console.WriteLine("3 : EXIT");

                int select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        CustomerPanel();
                        break;
                    case 2:
                        AdminAccess();
                        break;
                    case 3:
                        Console.WriteLine("OK THANKYOU..");
                        break;
                }
            }
        }

     //Admin Panel
        static void AdminAccess()
        {
            int adminPIN = 4004;
            Console.WriteLine("Enter Admin PIN");
            int enteredKey = Convert.ToInt32(Console.ReadLine());

            if (enteredKey != adminPIN)
            {
                Console.WriteLine("Sorry...Access Denied");
                return;
            }

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("--ADMIN PANEL--");
                Console.WriteLine("1 : OPEN NEW ACCOUNT");
                Console.WriteLine("2 : SHOW ACCOUNT INFO");
                Console.WriteLine("3 : REMOVE ACCOUNT");
                Console.WriteLine("4 : RETURN TO LOGIN PORTAL");

                int select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        OpenNewAccount();
                        break;
                    case 2:
                        DisplayAccount();
                        break;
                    case 3:
                        CloseAccount();
                        break;
                    case 4:
                        return;
                }
            }
        }

        // Create account OR open new account
        static void OpenNewAccount()
        {
            Random rnd = new Random();
            accountNumber = rnd.NextInt64(1000000000L, 10000000000L);

            Console.WriteLine("Genrating account ID : " + accountNumber);
            Console.WriteLine("Enter Username");
            accountHolderName = Console.ReadLine();

            Console.WriteLine("Enter Amount");
            totalAmount = Convert.ToDouble(Console.ReadLine());

            isAccountReady = true;
            Console.WriteLine("Account Successfully opened");
        }

        // Show account information
        static void DisplayAccount()
        {
            if (!isAccountReady)
            {
                Console.WriteLine("Sorry.. No Record Found");
                return;
            }

            Console.WriteLine("ACCOUNT ID      : " + accountNumber);
            Console.WriteLine("CUSTOMER NAME  : " + accountHolderName);
            Console.WriteLine("CURRENT FUNDS  : " + totalAmount);
        }

        // Delete account
        static void CloseAccount()
        {
            if (!isAccountReady)
            {
                Console.WriteLine("No Active Account Unavailable");
                return;
            }

            accountNumber = 0;
            accountHolderName = null;
            totalAmount = 0;
            secretPIN = 0;
            isAccountReady = false;
            isPinReady = false;

            Console.WriteLine("Account has been Terminated");
        }

        //Custmor Panel
        static void CustomerPanel()
        {
            if (!isAccountReady)
            {
                Console.WriteLine("Account does not Exist");
                return;
            }

            if (!isPinReady)
            {
                Console.WriteLine("Security PIN is not set...First set your PIN");
                SetupPin();
                return;
            }

            Console.WriteLine("Custmer Access Granted");

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1 : ADD MONEY");
                Console.WriteLine("2 : REMOVE MONEY");
                Console.WriteLine("3 : VIEW BALANCE");
                Console.WriteLine("4 : EXIT TO MAIN MENU");

                int choice = Convert.ToInt32 (Console.ReadLine());

                Console.WriteLine("Enter your PIN");
                int verifyPin = Convert.ToInt32(Console.ReadLine());

                if (verifyPin != secretPIN)
                {
                    Console.WriteLine("Invalid PIN Entered");
                    return;
                }

                if (choice == 1) AddFunds();
                else if (choice == 2) RemoveFunds();
                else if (choice == 3) ShowBalance();
                else if (choice == 4) return;
                else Console.WriteLine("Invalid Choice");
            }
        }

        // Create PIN
        static void SetupPin()
        {
            Console.WriteLine("Set 4 Digit Secret PIN");
            secretPIN = Convert.ToInt32(Console.ReadLine());
            isPinReady = true;
            Console.WriteLine("PIN set successfully");
        }

        // Deposit balance
        static void AddFunds()
        {
            Console.WriteLine("Enter amount to add");
            double cash = Convert.ToDouble(Console.ReadLine());

            if (cash < 0)
                Console.WriteLine("Amount not acceptable");
            else
                totalAmount += cash;
        }

        // Withdraw balance
        static void RemoveFunds()
        {
            Console.WriteLine("Enter Amount to withdraw");
            double cash = Convert.ToDouble(Console.ReadLine());

            if (cash < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Input");
                Console.ResetColor();
            }
            else if (cash > totalAmount)
            {
                Console.WriteLine("Your Balance is too Low");
            }
            else
            {
                totalAmount -= cash;
                Console.WriteLine("Please.. Collect Your Amount");
            }
        }

        // Check Balanace
        static void ShowBalance()
        {
            Console.WriteLine("Available Balance : " + totalAmount);
        }


//MAIN METHOD
        static void Main(string[] args)
        {
            LoginPortal();
        }
    }
}
