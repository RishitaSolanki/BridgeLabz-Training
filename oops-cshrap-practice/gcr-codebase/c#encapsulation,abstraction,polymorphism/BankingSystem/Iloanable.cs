using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.oops.BankingSystem
{
    public interface Iloanable
    {
        public void ApplyForLoan();

        public bool CalculateLoanEligibility(double amount);
    }
}


