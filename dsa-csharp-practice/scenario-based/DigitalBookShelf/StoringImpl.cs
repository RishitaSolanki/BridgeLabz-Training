using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.DigitalBookShelf
{
    public class StoringImpl : IStorable
    {
        public void AddBook(EBook book, BookShelf shelf)
        {
            for (int i = 0; i < shelf.storage.Length; i++)
            {
                if (shelf.storage[i] == null)
                {
                    shelf.storage[i] = book;
                    break;
                }
                if (i == 99)
                {
                    Console.WriteLine("Shelf is full!");
                }
            }
        }

        public string SearchByAuthor(string authSearch, BookShelf shelf)
        {
            for (int i = 0; i < shelf.storage.Length; i++)
            {
                if (shelf.storage[i].name.Split('-')[1] == authSearch)
                {
                    return shelf.storage[i].name + " is found at " + i + " place";
                }
            }
            return "Book not found!";
        }

        public void SortBooks(BookShelf shelf)
        {
            int n = shelf.storage.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (shelf.storage[j] != null && shelf.storage[j + 1] != null)
                    {
                        if (shelf.storage[j].name.CompareTo(shelf.storage[j + 1].name) > 0)
                        {
                            EBook temp = shelf.storage[j];
                            shelf.storage[j] = shelf.storage[j + 1];
                            shelf.storage[j + 1] = temp;
                        }
                    }
                }
            }
        }
    }
}