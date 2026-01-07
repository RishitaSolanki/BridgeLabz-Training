using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace projectTwo.oops.OnlineFoodDeliverySystem
{

   // Use an interface IDiscountable with methods ApplyDiscount() and GetDiscountDetails().
    public interface IDiscountable
    {
        double ApplyDiscount();
        string GetDiscountDetails();
    }
}
