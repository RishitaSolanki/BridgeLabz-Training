using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.AddressBookSystem
{
    public class AddressBookMenu
    {

         private readonly IAddressBook addressBook;

        private AddressBook[] addressBooks = new AddressBook[10];

        private int bookCount = 0;


            public void ShowMenu()
            {
                int option;

                do
                {
                    Console.WriteLine("1. Add Contact");

                    Console.WriteLine("2. Edit Contact");

                    Console.WriteLine("3. Delete Contact");

                    Console.WriteLine("4. Display All Contacts");

                    Console.WriteLine("5. Exit");

                    Console.Write("Enter choice: ");
                    option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            addressBook.AddContact();
                            break;
                        case 2:
                            addressBook.EditContact();
                            break;
                        case 3:
                            addressBook.DeleteContact();
                            break;
                        case 4:
                            addressBook.DisplayContact();
                            break;
                        case 5:
                            Console.WriteLine("Thank you!");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid choice");
                            Console.ResetColor();
                            break;
                    }
                }
                while (option != 5);
            }
        private void SelectAddressBook()
        {
            Console.Write("Enter Address Book Name: ");
            string name = Console.ReadLine();

            for (int i = 0; i < bookCount; i++)
            {
                if (addressBooks[i].AddressBookName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    addressBookMenu(addressBooks[i]);
                    return;
                }
            }

            Console.WriteLine("Address Book not found!");
        }

        private void addressBookMenu(AddressBook book)
        {
            int choice;

            do
            {
                Console.WriteLine($"\nAddress Book: {book.AddressBookName}");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Display Contacts");
                Console.WriteLine("3. Back");

                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        book.AddContact();
                        break;
                    case 2:
                        book.DisplayContacts();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
            while (choice != 3);
        }
    }

    }

