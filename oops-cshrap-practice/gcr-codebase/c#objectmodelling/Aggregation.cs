using System;
using System.Collections.Generic;

// book class
class Book
{
    public string Title;
    public string Author;

    //constructor
    public Book(string enterTitle, string enterAuthor)
    {
        this.Title = enterTitle;
        this.Author = enterAuthor;
    }
}

// Library class 
class Library
{
    public string LibraryName;
    public List<Book> Books;

    //constructor
    public Library(string libraryName)
    {
        this.LibraryName = libraryName;
        this.Books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void ShowBooks()
    {
        Console.WriteLine("Library: " + LibraryName);

        foreach (Book book in Books)
        {
            Console.WriteLine(book.Title + " by " + book.Author);
        }

        Console.WriteLine();
    }
}

// MAIN CLASS
class Aggregation
{
    //MAIN METHOD
    public static void Main(String[] args)
    {

        Book b1 = new Book("Rich Dad Poor Dad", "Rishita");
        Book b2 = new Book("Atomic Habits", "James Clear");


        Library l1 = new Library("Central Library");
        Library l2 = new Library("Gate 2 Library");


        l1.AddBook(b1);
        l1.AddBook(b2);

        l2.AddBook(b2);


        l1.ShowBooks();
        l2.ShowBooks();
    }
}
