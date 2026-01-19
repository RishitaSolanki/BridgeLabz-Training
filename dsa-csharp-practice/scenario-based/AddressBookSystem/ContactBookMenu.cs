using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.AddressBookSystem
{
     public class ContactBookMenu
    {
            private IContactable contactManager;

            public ContactBookMenu(IContactable contactManager)
            {
                this.contactManager = contactManager;
            }

            public void Manage(AddressBook book)
            {
                bool inside = true;

                while (inside)
                {
                    Utility.ShowContactMenu(book.bookName);
                    string choice = Console.ReadLine();

                    if (choice == "1") Add(book);
                    else if (choice == "2") Edit(book);
                    else if (choice == "3") Delete(book);
                    else if (choice == "4") Sort(book);
                    else if (choice == "5") inside = false;
                }
            }

            private void Add(AddressBook book)
            {
                EContact c = Utility.CreateContactWithUI();
                contactManager.AddContact(book, c);
                Utility.WaitForKey();
            }

            private void Edit(AddressBook book)
            {
                string name = Utility.GetInput("Enter Name to Edit");
                EContact c = contactManager.ShowContact(book, name);

                if (c == null)
                {
                    Console.WriteLine("    [!] Not Found.");
                    Utility.WaitForKey();
                    return;
                }

                EContact updated = Utility.GetUpdatedContactDetails(c);
                contactManager.EditContact(book, c,
                    updated.firstName, updated.lastName, updated.address,
                    updated.city, updated.state, updated.zip,
                    updated.phoneNumber, updated.eMail);

                Console.WriteLine("    [!] Contact Updated.");
                Utility.WaitForKey();
            }

            private void Delete(AddressBook book)
            {
                string name = Utility.GetInput("Enter Name to Delete");
                EContact c = contactManager.ShowContact(book, name);

                if (c == null)
                    Console.WriteLine("    [!] Not Found.");
                else
                {
                    contactManager.DeleteContact(book, c);
                    Console.WriteLine("    [!] Contact Deleted.");
                }

                Utility.WaitForKey();
            }

            private void Sort(AddressBook book)
            {
                contactManager.SortContacts(book);
                Console.WriteLine("    [!] Contacts Sorted.");
                Utility.WaitForKey();
            }
        }
    }


