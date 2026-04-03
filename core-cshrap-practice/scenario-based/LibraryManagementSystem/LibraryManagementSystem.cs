using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScenarioBased
{
    class LibraryManagementSystem
    {

        // LOGIN PORTAL
        public static void LoginPortal(string[,] bookStore)
        {
            while (true)
            {
                Console.WriteLine("SELECT LOGIN TYPE");
                Console.WriteLine("1 -> Librarian");
                Console.WriteLine("2 -> Reader");
                Console.WriteLine("3 -> Exit");

                int loginChoice = Convert.ToInt32(Console.ReadLine());

                switch (loginChoice)
                {
                    case 1:
                        LibrarianPanel(bookStore);
                        break;

                    case 2:
                        ReaderPanel(bookStore);
                        break;

                    case 3:
                        Console.WriteLine("Ok Thankyou!");
                        return;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("INVALID SELECTION");
                        Console.ResetColor();
                        break;
                }
            }
        }

        //ThIS IS A READER PANEL
        public static void ReaderPanel(string[,] bookStore)
        {
            while (true)
            {
                Console.WriteLine("1.  View Book List");
                Console.WriteLine("2.  Find Book By Name");
                Console.WriteLine("3.  Go Back");

                int Choice = Convert.ToInt32(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        BookList(bookStore);
                        break;

                    case 2:
                        FindingBook(bookStore);
                        break;

                    case 3:
                        return;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("INVALID SELECTION");
                        Console.ResetColor();
                        break;
                }
            }
        }



        // ThIS IS A LIBRARIAN PANEL
          public static void LibrarianPanel(string[,] bookStore)
        {
            Console.WriteLine("ENTER SECURITY CODE");
            int loginCode = Convert.ToInt32(Console.ReadLine());

            if (loginCode != 4321)
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("ACCESS DENIED");
                Console.ResetColor();
                return;
            }

            while (true)
            {
                Console.WriteLine("1. Show All Books");
                Console.WriteLine("2. Modify Book Info");
                Console.WriteLine("3. Update Book Availability");
                Console.WriteLine("4. Go Back");

                int Choice = Convert.ToInt32(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        BookList(bookStore);
                        break;

                    case 2:
                        EditBookInfo(bookStore);
                        break;

                    case 3:
                        UpdateBookList(bookStore);
                        break;

                    case 4:
                        return;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("INVALID OPTION");
                        Console.ResetColor();
                        break;
                }
            }
        }


        // DISPLAY ALL BOOKS
        static void BookList(string[,] bookStore)
        {
            Console.WriteLine("--LIBRARY COLLECTION--");

            for (int i = 0; i < bookStore.GetLength(0); i++)
            {
                Console.WriteLine(
                    (i + 1) + ") " +
                    bookStore[i, 0] + " | " +
                    bookStore[i, 1] + " | " +
                    bookStore[i, 2]
                );
            }
        }


        // EDITS TITLE AND AUTHOR
        static void EditBookInfo(string[,] bookStore)
        {
            BookList(bookStore);

            Console.WriteLine("SELECT BOOK NUMBER TO EDIT");

            int index = Convert.ToInt32(Console.ReadLine()) - 1;

            if (index < 0 || index >= bookStore.GetLength(0))
            {
                Console.WriteLine("BOOK NOT FOUND");
                return;
            }

            Console.WriteLine("ENTER UPDATED BOOK NAME");
            bookStore[index, 0] = Console.ReadLine();

            Console.WriteLine("ENTER UPDATED AUTHOR NAME");
            bookStore[index, 1] = Console.ReadLine();

            Console.WriteLine("BOOK INFORMATION SAVED");
        }


        // UPDATES AVAILABILITY
        public static void UpdateBookList(string[,] bookStore)
        {
            BookList(bookStore);

            Console.WriteLine("SELECT BOOK NUMBER TO CHANGE STATUS");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;

            if (index < 0 || index >= bookStore.GetLength(0))
            {
                Console.WriteLine("INVALID BOOK SELECTION");
                return;
            }

            Console.WriteLine("ENTER STATUS (Available / Issued)");
            bookStore[index, 2] = Console.ReadLine();

            Console.WriteLine("STATUS UPDATED SUCCESSFULLY");
        }

        // SEARCH BOOKS
        static void FindingBook(string[,] bookStore)
        {
            Console.WriteLine("TYPE BOOK NAME TO SEARCH");
            string searchBook = Console.ReadLine();

            for (int i = 0; i < bookStore.GetLength(0); i++)
            {
                if (bookStore[i, 0].Equals(searchBook, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(
                        "MATCH FOUND -> " +
                        bookStore[i, 0] + " | " +
                        bookStore[i, 1] + " | " +
                        bookStore[i, 2]
                    );
                    return;
                }
            }

            Console.WriteLine("NO MATCH FOUND");
        }

        static void Main(string[] args)
        {
            string[,] bookStore =
            {
               { "Harry Potter and the Sorcerer's Stone", "J.K. Rowling", "Available" },
               { "The Power of Habit", "Charles Duhigg", "Available" },
               { "Ikigai", "Hector Garcia", "Available" },
               { "The 7 Habits of Highly Effective People", "Stephen R. Covey", "Issued" },
               { "Wings of Fire", "A.P.J. Abdul Kalam", "Available" }

            };

           LoginPortal(bookStore);
        }
    }
}