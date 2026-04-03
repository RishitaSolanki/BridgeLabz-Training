using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo
{
    public class Book
    {
        public string title;
        public string author;
        public double price;

//DEFAULT CONSTRUCTOR
        public Book()
        {  
            price=0.0;    
            author = "unkown";
            title = "unkown";
        }

//PARAMETERIZED CONSTRUCTOR
        public Book(string Title, string Author, double Price)
        {
            title = Title;
            author = Author;
            price = Price;
        }

//MAIN METHOD

        public static void Main(string[] args)
        {
            Book  B1=new Book();

            Console.WriteLine("Default Constructor value");
            Console.WriteLine(B1.title + "," + B1.author + "," + B1.price);

            Console.WriteLine("Parameterized Constructor value");
            Book  B2=new Book("RichDad-PoorDad" , "Rishita" ,350);

            Console.WriteLine(B2.title + "," + B2.author + "," + B2.price); 



        }


    }
}
