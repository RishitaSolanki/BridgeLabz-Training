using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.BookShelf
{
    public interface ILibraryService
    {
        void AddBook(string genre, string book);
        void RemoveBook(string genre, string book);
        void Display();
    }
}
