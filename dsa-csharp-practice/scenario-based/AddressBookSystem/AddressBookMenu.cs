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
                //Console.WriteLine("2. Edit Contact");
                //Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Display All Contacts");
                //Console.WriteLine("5. Search by City");   
                //Console.WriteLine("6. Search by State");  
                Console.WriteLine("7. Search by Zip");    // UC10
                Console.WriteLine("8. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        addressBook.AddContact();
                        break;
                    //case "2":
                    //    addressBook.EditContact();
                    //    break;

                    //case "3":
                    //    addressBook.DeleteContact();
                    //    break;
                    case "4":
                        addressBook.DisplayContact();
                        break;
                    //case "5":
                    //    SearchByCity();    
                    //    break;

                    //case "6":
                    //    SearchByState();   
                    //    break;

                    case "7":
                        SearchByZip();     // UC10
                        break;

                    case "8":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice!\n");
                        break;
                }
            }
        }

        
        //private void SearchByCity()
        //{
        //    EContact[] contacts = addressBook.GetContactsArray();
        //    int count = addressBook.GetContactCount();

        //    if (count == 0)
        //    {
        //        Console.WriteLine("No contacts available to search.\n");
        //        return;
        //    }

        //    Console.Write("Enter city to search: ");
        //    string city = Console.ReadLine();
        //    bool found = false;

        //    for (int i = 0; i < count; i++)
        //    {
        //        if (contacts[i].City.Equals(city, StringComparison.OrdinalIgnoreCase))
        //        {
        //            contacts[i].DisplayContact();
        //            found = true;
        //        }
        //    }

        //    if (!found)
        //    {
        //        Console.WriteLine($"No contacts found in {city}.\n");
        //    }
        //}

    
        //private void SearchByState()
        //{
        //    EContact[] contacts = addressBook.GetContactsArray();
        //    int count = addressBook.GetContactCount();

        //    if (count == 0)
        //    {
        //        Console.WriteLine("No contacts available to search.\n");
        //        return;
        //    }

        //    Console.Write("Enter state to search: ");
        //    string state = Console.ReadLine();
        //    bool found = false;

        //    for (int i = 0; i < count; i++)
        //    {
        //        if (contacts[i].State.Equals(state, StringComparison.OrdinalIgnoreCase))
        //        {
        //            contacts[i].DisplayContact();
        //            found = true;
        //        }
        //    }

        //    if (!found)
        //    {
        //        Console.WriteLine($"No contacts found in {state}.\n");
        //    }
        //}

        // ---------------- UC10 ----------------
        private void SearchByZip()
        {
            EContact[] contacts = addressBook.GetContactsArray();
            int count = addressBook.GetContactCount();

            if (count == 0)
            {
                Console.WriteLine("No contacts available to search.\n");
                return;
            }

            Console.Write("Enter zip to search: ");
            string zip = Console.ReadLine();
            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (contacts[i].Zip.Equals(zip))
                {
                    contacts[i].DisplayContact();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine($"No contacts found with zip {zip}.\n");
            }
        }
    }
}


}



