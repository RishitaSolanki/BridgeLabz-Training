using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.LoanBuddy
{
    public class LoanBuddyMenu
    {
        public void Start()
        {
            while (true)
            {

                Console.Write("Enter applicant name: ");
                string name = Console.ReadLine();

                Console.Write("Enter credit score: ");
                int score = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter monthly income: ");
                double income = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter loan amount: ");
                double amount = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter loan duration in months: ");
                int months = Convert.ToInt32(Console.ReadLine());

                Applicant user = new Applicant(name, score, income, amount);

                Console.WriteLine();
                Console.WriteLine("1: Personal Loan");
                Console.WriteLine("2: Home Loan");
                Console.WriteLine("3: Auto Loan");

                int select = Convert.ToInt32(Console.ReadLine());

                LoanApplication loan;

                if (select == 1) loan = new PersonalLoan(user, months);

                else if (select == 2) loan = new HomeLoan(user, months);

                else if (select == 3) loan = new AutoLoan(user, months);
                else return; ;

                Console.WriteLine();

                if (loan.ApproveLoan())
                {
                    Console.WriteLine("Loan Approved");

                    Console.WriteLine("Monthly EMI: " +
                    Math.Round(loan.CalculateEMI(), 2));
                }
                else
                {
                    Console.WriteLine("Loan Rejected");
                }

                Console.WriteLine("1: FOR CONTINUE");

                Console.WriteLine("2: FOR EXIT");

                int ch = Convert.ToInt32(Console.ReadLine());

                if (ch == 2) return;
            }
        }
    }
}
