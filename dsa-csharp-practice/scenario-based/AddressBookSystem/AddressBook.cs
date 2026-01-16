using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.AddressBookSystem
{
   public class AddressBook
    {

        public string AddressBookName;

        private EContact[] contacts = new EContact[10];
        private int contactCount = 0;

        public AddressBook(string name)
        {
            AddressBookName = name;
        }

        public void AddContact()
        {
            if (contactCount >= contacts.Length)
            {
                Console.WriteLine("Contact limit reached");
                return;
            }

            EContact contact = new EContact();

            Console.Write("First Name: ");
            contact.FirstName = Console.ReadLine();

            Console.Write("Last Name: ");
            contact.LastName = Console.ReadLine();

            Console.Write("Address: ");
            contact.Address = Console.ReadLine();

            Console.Write("City: ");
            contact.City = Console.ReadLine();

            Console.Write("State: ");
            contact.State = Console.ReadLine();

            Console.Write("Zip: ");
            contact.Zip = Console.ReadLine();

            Console.Write("Phone: ");
            contact.PhoneNumber = Console.ReadLine();

            Console.Write("Email: ");
            contact.Email = Console.ReadLine();

            contacts[contactCount] = contact;
            contactCount++;

            Console.WriteLine("Contact Added Successfully");
        }

        public void DisplayContacts()
        {
            if (contactCount == 0)
            {
                Console.WriteLine("No Contacts Available");
                return;
            }

            for (int i = 0; i < contactCount; i++)
            {
                contacts[i].Display();
            }
        }
    }

}




