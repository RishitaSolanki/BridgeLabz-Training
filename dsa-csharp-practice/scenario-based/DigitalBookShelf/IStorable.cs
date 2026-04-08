using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.DigitalBookShelf
{
    //interface having method addbook,sortbook,searchbyauthor
    public interface IStorable
    {
        void AddBook(EBook book, BookShelf shelf);

        void SortBooks(BookShelf shelf);

        String SearchByAuthor(String bookSearch, BookShelf shelf);
    }
}

