using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Channels;

namespace ScenarioBased.LoanBuddy
{
    class LoanApplication : IApprovable
    {
        //Access modifiers to limit loan status changes to internal processes only
        protected Applicant applicant;
        protected int months;
        protected double interestRate;
        private bool approved;
        public LoanApplication(Applicant applicant, int months, double interestRate)
        {
            this.applicant = applicant;
            this.months = months;
            this.interestRate = interestRate;
            this.approved = false;
        }
        protected virtual bool CheckEligibility()
        {
            return applicant.GetCreditScore() >= 650 && applicant.GetIncome() >= applicant.GetLoanAmount() / 10;

        }
        public bool ApproveLoan()
        {
            approved = CheckEligibility();
            return approved;
        }
        public virtual double CalculateEMI()
        //Operators for EMI calculation: P × R × (1+R)^N / ((1+R)^N – 1)
        {
            double p = applicant.GetLoanAmount();
            double r = interestRate / 12 / 100;

            return (p * r * Math.Pow(1 + r, months)) / (Math.Pow(1 + r, months) - 1);

        }
    }
}
