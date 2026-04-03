using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.oops.LibraryManagementSystem
{
    public class LibraryManagementMain
    {
       public static void Main(string[] args)
        {
           
            List<LibraryItem> items = new List<LibraryItem>();

            items.Add(new Book(1, "Atomic Habits", "James Clear", 500));
            items.Add(new Magazine(2, "Kafan", "Munsi PremChand", "Jan 2024"));
            items.Add(new DVD(3, "Gunah ka devta", "dharmveer bharti", 120));

            Console.WriteLine("--LIBRARY ITEMS--");
            foreach (LibraryItem item in items)
            {
                item.GetItemDetails();

                if (item is IReservable)
                {
                    IReservable reservable = (IReservable)item;

                    bool available = reservable.CheckAvailability();

                    Console.WriteLine("Available: " + available);

                    if (available)
                    {
                        reservable.ReserveItem("Student123");
                    }
                }
               
            }

            Console.ReadKey();
        }
    }
}
