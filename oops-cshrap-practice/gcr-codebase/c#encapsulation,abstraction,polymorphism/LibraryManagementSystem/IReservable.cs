using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.oops.LibraryManagementSystem
{
   
   public interface IReservable
    {
        void ReserveItem(string borrowerName);
        bool CheckAvailability();
    }
}
