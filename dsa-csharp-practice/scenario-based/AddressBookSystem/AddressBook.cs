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

            Console.Write("First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();

            //UC6 Duplicate Check
            for (int i = 0; i < contactCount; i++)
            {
                if (contacts[i].FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                    contacts[i].LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Duplicate contact found. Cannot add.");
                    return;
                }
            }

            // If not duplicate → add
            EContact contact = new EContact();
            contact.FirstName = firstName;
            contact.LastName = lastName;

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




