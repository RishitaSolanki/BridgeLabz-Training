using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.AddressBookSystem
{
    public class AddressBookMenu
    {

         private readonly IAddressBook addressBook;

            public AddressBookMenu()
            {
                addressBook = new AddressBook();
            }

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
        }

    }

