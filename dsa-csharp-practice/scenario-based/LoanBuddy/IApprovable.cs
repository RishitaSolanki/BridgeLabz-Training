using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.LoanBuddy
{
    // Interface IApprovable with approveLoan() and calculateEMI().
    public interface IApprovable
    {
            bool ApproveLoan();
            double CalculateEMI();
        }
    }

