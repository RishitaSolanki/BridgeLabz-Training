using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.AddressBookSystem
{
    public class AddressBookMenu
    {

            private AddressBook[] bookShelf = new AddressBook[10];
            private IAddressable bookManager = new AddressableImpl();
            private IContactable contactManager = new ContactableImpl();

            public void Start()
            {
                bool running = true;

                while (running)
                {
                    Utility.PrintLogo();
                    Utility.ShowBookMenu();
                    string choice = Console.ReadLine();

                    if (choice == "1") CreateBook();
                    else if (choice == "2") OpenBook();
                    else if (choice == "3") DeleteBook();
                    else if (choice == "4") SearchByCity();
                    else if (choice == "5") SearchByState();
                    else if (choice == "6") FindPersonByCity();
                    else if (choice == "7") FindPersonByState();
                    else if (choice == "8") CountByCity();
                    else if (choice == "9") CountByState();
                    else if (choice == "10") running = false;
                    else Console.WriteLine("    Invalid Option.");
                }
            }

            private void CreateBook()
            {
                string name = Utility.GetInput("Enter New Book Name");

                if (bookManager.FindBook(bookShelf, name) != null)
                {
                    Console.WriteLine("    [!] Book already exists.");
                    Utility.WaitForKey();
                    return;
                }

                for (int i = 0; i < bookShelf.Length; i++)
                {
                    if (bookShelf[i] == null)
                    {
                        bookShelf[i] = new AddressBook(name);
                        Console.WriteLine($"    [!] Address Book '{name}' Created.");
                        Utility.WaitForKey();
                        return;
                    }
                }

                Console.WriteLine("    [!] Shelf Full.");
                Utility.WaitForKey();
            }

            private void OpenBook()
            {
                string name = Utility.GetInput("Enter Book Name to Open");
                AddressBook book = bookManager.FindBook(bookShelf, name);

                if (book == null)
                {
                    Console.WriteLine("    [!] Book Not Found.");
                    Utility.WaitForKey();
                    return;
                }

                ContactBookMenu contactMenu = new ContactBookMenu(contactManager);
                contactMenu.Manage(book);
            }

            private void DeleteBook()
            {
                string name = Utility.GetInput("Enter Book Name to Delete");

                for (int i = 0; i < bookShelf.Length; i++)
                {
                    if (bookShelf[i] != null && bookShelf[i].bookName == name)
                    {
                        bookShelf[i] = null;
                        Console.WriteLine($"    [!] '{name}' Deleted.");
                        Utility.WaitForKey();
                        return;
                    }
                }

                Console.WriteLine("    [!] Book Not Found.");
                Utility.WaitForKey();
            }

            private void SearchByCity()
            {
                string city = Utility.GetInput("Enter City");
                Utility.PrintSearchResults(bookManager.FindByCity(bookShelf, city));
                Utility.WaitForKey();
            }

            private void SearchByState()
            {
                string state = Utility.GetInput("Enter State");
                Utility.PrintSearchResults(bookManager.FindByState(bookShelf, state));
                Utility.WaitForKey();
            }

            private void FindPersonByCity()
            {
                string city = Utility.GetInput("Enter City");
                string name = Utility.GetInput("Enter Person Name");
                Utility.PrintSingleResult(bookManager.FindByCityAndName(bookShelf, city, name));
                Utility.WaitForKey();
            }

            private void FindPersonByState()
            {
                string state = Utility.GetInput("Enter State");
                string name = Utility.GetInput("Enter Person Name");
                Utility.PrintSingleResult(bookManager.FindByStateAndName(bookShelf, state, name));
                Utility.WaitForKey();
            }

            private void CountByCity()
            {
                string city = Utility.GetInput("Enter City");
                Utility.PrintCountResult("City", city, bookManager.CountByCity(bookShelf, city));
                Utility.WaitForKey();
            }

            private void CountByState()
            {
                string state = Utility.GetInput("Enter State");
                Utility.PrintCountResult("State", state, bookManager.CountByState(bookShelf, state));
                Utility.WaitForKey();
            }
        }
    }



