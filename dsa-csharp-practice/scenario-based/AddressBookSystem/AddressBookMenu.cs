using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.AddressBookSystem
{
    public class AddressBookMenu
    {
            private AddressBook[] addressBooks = new AddressBook[5];
            private int bookCount = 0;

            
            public void ShowMenu()
            {
                int choice;

                do
                {
                    Console.WriteLine("--ADDRESS BOOK SYSTEM--");
                    Console.WriteLine("1. Create Address Book");
                    Console.WriteLine("2. Select Address Book");
                    Console.WriteLine("3. Exit");

                    Console.Write("Enter choice: ");
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            CreateAddressBook();
                            break;

                        case 2:
                            SelectAddressBook();
                            break;

                        case 3:
                            Console.WriteLine("Thank you!");
                            break;

                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                }
                while (choice != 3);
            }

            
            private void CreateAddressBook()
            {
                if (bookCount >= addressBooks.Length)
                {
                    Console.WriteLine("Address Book limit reached");
                    return;
                }

                Console.Write("Enter Address Book Name: ");
                string name = Console.ReadLine();

               
                for (int i = 0; i < bookCount; i++)
                {
                    if (addressBooks[i].AddressBookName.Equals(name, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Address Book already exists");
                        return;
                    }
                }

                addressBooks[bookCount] = new AddressBook(name);
                bookCount++;

                Console.WriteLine("Address Book created successfully");
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

                Console.WriteLine("Address Book not found");
            }

            
            private void addressBookMenu(AddressBook book)
            {
                int choice;

                do
                {
                    Console.WriteLine($"\n===== Address Book : {book.AddressBookName} =====");
                    Console.WriteLine("1. Add Contact");
                    Console.WriteLine("2. Display All Contacts");
                    Console.WriteLine("3. Search Contact by City");
                    Console.WriteLine("4. Search Contact by State");
                    Console.WriteLine("5. Back to Main Menu");

                    Console.Write("Enter choice: ");
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            book.AddContact();          // UC6 logic inside
                            break;

                        case 2:
                            book.DisplayContacts();
                            break;

                        case 3:
                            Console.Write("Enter City: ");
                            string city = Console.ReadLine();
                            book.SearchByCity(city);    // UC7
                            break;

                        case 4:
                            Console.Write("Enter State: ");
                            string state = Console.ReadLine();
                            book.SearchByState(state);  // UC7
                            break;

                        case 5:
                            break;

                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                }
                while (choice != 5);
            }
        }



    }


