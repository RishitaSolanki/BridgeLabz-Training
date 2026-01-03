using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.accessModifier
{
    public class BookLibrarySystem
    {
        //MAIN METHOD
        static void Main(string[] args)
        {
            EBook eB1 = new EBook("Robert Downey Jr.", "Marvel", "937-3474834");

            eB1.ShowDetails();

            Console.WriteLine("ISBN from Main : " + eB1.iSBN);
        }
    }

    //parent class
    public class Book
    {
        public string iSBN;
        protected string title;
        private string author;

        public Book(string t, string a, string iSBN)
        {
            this.title = t;
            this.author = a;
            this.iSBN = iSBN;
        }
        public string GetAuthor()
        {
            return author;
        }
        public void SetAuthor(string authorName)
        {
            author = authorName;
        }

    }

    //child class
    public class EBook : Book
    {
        public EBook(string title, string author, string iSBN) : base(title, author, iSBN) { }

        public void ShowDetails()
        {
            Console.WriteLine("Displaying the details");
            Console.WriteLine("ISBN : " + iSBN);
            Console.WriteLine("Title : " + title);
            Console.WriteLine("Author : " + GetAuthor());
        }
    }
}
