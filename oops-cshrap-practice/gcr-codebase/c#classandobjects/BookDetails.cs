using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo
{
    public class BookDetails
    {
        string Title;
        string Author;
        double Price;

        //Parmeterized constructor
        public BookDetails(string enteredTitle, string enteredAuthor, double enteredPrice)
        {
            this.Title = enteredTitle;
            this.Author = enteredAuthor;
            this.Price = enteredPrice;

        }

        public void ShowBookDetails()
        {
            Console.WriteLine("Book Details are given below");
            Console.WriteLine("Title of the book is : " + Title);
            Console.WriteLine("Author of the book is : " + Author);
            Console.WriteLine("Price of the book is : " + Price);

        }

        //MAIN METHOD
        static void Main(string[] args)
        {
            BookDetails B1 = new BookDetails("Dev ki kahaniya", "Rishita", 300);
            B1.ShowBookDetails();
        }
    }
}
