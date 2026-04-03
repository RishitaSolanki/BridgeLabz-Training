using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo
{
    public class LibraryBookSystem
    {
        public string title;
        public string author;
        public double price;
        public bool IsBookAvailable;

        // Parameterized Constructor
        public LibraryBookSystem(string Title, string Author, double Price)
        {
            this.title = Title;
            this.author = Author;
            this.price = Price;
            this.IsBookAvailable = true;   
        }


        //Method top borrow book
        public  void BorrowBook()
        {
            if (IsBookAvailable)
            {
                IsBookAvailable = false;
                Console.WriteLine("You have successfully borrowed the book: " + title);
            }
            else
            {
                Console.WriteLine("Sorry, the book is not available");
            }
        }

        public static void Main(string[] args)
        {
            LibraryBookSystem book1 = new LibraryBookSystem("The Alchemist", "Paulo Coelho", 399);

            book1.BorrowBook(); 
            
            book1.BorrowBook();   
        

    }
    }
}
