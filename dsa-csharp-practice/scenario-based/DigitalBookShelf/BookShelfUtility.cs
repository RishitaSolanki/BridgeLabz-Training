using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.DigitalBookShelf
{
    public class BookShelfUtility
    {
        public static void RunInterface()
        {
            BookShelf myShelf = new BookShelf();

            IStorable bookManager = new StoringImpl();

            bool isRunning = true;

            Console.WriteLine("Welcome to BookBuddy!");

            while (isRunning)
            { 
                Console.WriteLine("1. Add a Book");
                Console.WriteLine("2. Sort Books by Name");
                Console.WriteLine("3. Search by Author");
                Console.WriteLine("4. View All Books");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("\nEnter Book details in format 'Title-Author' :");
                        string inputName = Console.ReadLine();

                        
                        if (!inputName.Contains("-"))
                        {
                            Console.WriteLine("Invalid format! You must include a '-' to separate Title and Author.");
                        }



                        else
                        {
                            EBook newBook = new EBook(inputName);

                            bookManager.AddBook(newBook, myShelf);

                            Console.WriteLine("Book added successfully.");
                        }
                        break;


                    case "2":
                        Console.WriteLine("\nSorting books...");
                        try
                        {
                            bookManager.SortBooks(myShelf);
                            Console.WriteLine("Books sorted alphabetically!");
                            PrintShelf(myShelf);
                        }
                        catch (NullReferenceException)
                        {
                            Console.WriteLine("Error: The shelf contains empty slots. The current Sort implementation cannot handle nulls.");
                        }
                        break;


                    case "3":
                        Console.Write("\nEnter Author Name to search: ");

                        string authorName = Console.ReadLine();
                        try
                        {
                            string result = bookManager.SearchByAuthor(authorName, myShelf);
                            Console.WriteLine(result);
                        }
                        catch (NullReferenceException)
                        {
                            Console.WriteLine("Error: Hit a null slot while searching. Please check StoringImpl logic.");
                        }
                        break;


                    case "4":
                        PrintShelf(myShelf);
                        break;


                    case "5":
                        isRunning = false;
                        Console.WriteLine("Exiting application.");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        


        private static void PrintShelf(BookShelf shelf)
        {
            Console.WriteLine("Current Shelf");
            bool isEmpty = true;
            for (int i = 0; i < shelf.storage.Length; i++)
            {
                if (shelf.storage[i] != null)
                {
                    Console.WriteLine($"Slot {i}: {shelf.storage[i].name}");
                    isEmpty = false;
                }
            }

            if (isEmpty) Console.WriteLine("Shelf is empty.");
        }
    }
}
}
