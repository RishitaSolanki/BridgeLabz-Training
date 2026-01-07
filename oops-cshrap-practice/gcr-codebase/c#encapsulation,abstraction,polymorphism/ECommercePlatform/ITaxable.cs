using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.oops.ECommercePlatform
{
    // Implement an interface ITaxable with methods CalculateTax()
    // and GetTaxDetails() for applicable product categories.
    public interface ITaxable
    {
        double CalculateTax();
        string GetTaxDetails();


    }
}
