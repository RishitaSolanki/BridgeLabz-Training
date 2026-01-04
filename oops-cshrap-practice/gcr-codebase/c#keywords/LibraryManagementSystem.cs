using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.Keywords
{
    public class Book
    {
        public static string LibraryName = "College Library";
        public readonly string ISBN;
        public string Title;
        public string Author;

        //Constructor
        public Book(string enterTitle, string enterAuthor, string enterISBN)
        {
            this.Title = enterTitle;
            this.Author = enterAuthor;
            this.ISBN = enterISBN;
        }


        public static void DisplayLibraryName()
        {
            Console.WriteLine("Library Name: " + LibraryName);
        }



        public void ShowBookDetails(object book)
        {


            if (book is Book)
            {
                Console.WriteLine("Title  : " + Title);
                Console.WriteLine("Author : " + Author);
                Console.WriteLine("ISBN   : " + ISBN);
            }
            else
            {
                Console.WriteLine("Invalid book ");
            }


        }
    }


    //MAIN CLASS
    class LibraryManagementSystem
    {

        //MAIN METHOD
        public static void Main(string[] args)
        {

            Book.DisplayLibraryName();
            Book b1 = new Book("RichDad and PoorDad", "Hehe", "ISBN-11100");
            Book b2 = new Book("You can", "Haha", "ISBN-11200");

            b1.ShowBookDetails(b1);
            Console.WriteLine();

            b2.ShowBookDetails(b2);
        }
    }
}
