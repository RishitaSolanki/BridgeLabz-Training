using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace ScenarioBased.AddressBookSystem
{
    public class AddressBookMain
    {
        public static void Main(string[] args) { 

        Console.WriteLine("Welcome to Address Book Program");

        IAddressBook contact = new EContact();

        contact.TakeInput();      
        
          
          contact.EditContact();

            // UC3
            contact.DeleteContact();

            contact.DisplayContact();

        }
}
}
