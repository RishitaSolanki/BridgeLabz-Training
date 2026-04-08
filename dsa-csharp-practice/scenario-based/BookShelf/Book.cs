using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.BookShelf
{

    public class Book
    {
        public string Title { get; }
        public string Author { get; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return Title + " by " + Author;
        }
    }


}
