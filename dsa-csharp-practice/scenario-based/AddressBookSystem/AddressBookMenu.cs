using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.AddressBookSystem
{
    public class AddressBookMenu: IAddressBook 
    {


        private AddressBook addressBook = new AddressBook();

        public void AddContact()
        {
            throw new NotImplementedException();
        }

        public void DisplayContact()
        {
            throw new NotImplementedException();
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("---- Address Book Menu ----");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Display All Contacts");
                Console.WriteLine("5. Search by City"); // UC8
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        addressBook.AddContact();
                        break;
                    case "2":
                        // addressBook.EditContact();
                        break;
                    case "3":
                        // addressBook.DeleteContact();
                        break;
                    case "4":
                        addressBook.DisplayContact();
                        break;
                    case "5":
                        SearchByCity(); // UC8
                        break;
                    case "6":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice!\n");
                        break;
                }
            }
        }

        private void SearchByCity()
        {
            EContact[] contacts = addressBook.GetContactsArray();
            int count = addressBook.GetContactCount();

            if (count == 0)
            {
                Console.WriteLine("No contacts available to search.\n");
                return;
            }

            Console.Write("Enter city to search: ");
            string city = Console.ReadLine();
            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (contacts[i].City.Equals(city, StringComparison.OrdinalIgnoreCase))
                {
                    contacts[i].DisplayContact();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine($"No contacts found in {city}.\n");
            }
        }






    }
}


