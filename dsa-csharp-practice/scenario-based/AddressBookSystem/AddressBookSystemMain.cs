using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem.AddressBookSystem
{
    public class AddressBookSystemMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            EContact contact = new EContact();
            contact.DisplayContact();
           
        }
    }
}

