using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectThree.Linkedlist
{
    using System;

    namespace DoublyLinkedListLibrary
    {
        
        class BookNode
        {
            public int BookId;
            public string Title;
            public string Author;
            public string Genre;
            public bool IsAvailable;
            public BookNode Prev;
            public BookNode Next;


            //constructor
            public BookNode(int id, string title, string author, string genre, bool available)
            {
                this.BookId = id;
                this.Title = title;
                this.Author = author;
                this.Genre = genre;
                this.IsAvailable = available;
                this.Prev = null;
                this.Next = null;
            }
        }

        // Doubly Linkedlist
        //Add a new book at the beginning, end, or at a specific position.

        class Library
        {
            private BookNode head;
            private BookNode tail;

           
            public void AddAtBeginning(int id, string title, string author, string genre, bool available)
            {
                BookNode newNode = new BookNode(id, title, author, genre, available);

                if (head == null)
                    head = tail = newNode;
                else
                {
                    newNode.Next = head;
                    head.Prev = newNode;
                    head = newNode;
                }
            }

           
            public void AddAtEnd(int id, string title, string author, string genre, bool available)
            {
                BookNode newNode = new BookNode(id, title, author, genre, available);

                if (tail == null)
                    head = tail = newNode;
                else
                {
                    tail.Next = newNode;
                    newNode.Prev = tail;
                    tail = newNode;
                }
            }

          
            public void AddAtPosition(int position, int id, string title, string author, string genre, bool available)
            {
                if (position <= 1 || head == null)
                {
                    AddAtBeginning(id, title, author, genre, available);
                    return;
                }

                BookNode temp = head;
                for (int i = 1; i < position - 1 && temp.Next != null; i++)
                    temp = temp.Next;

                if (temp.Next == null)
                {
                    AddAtEnd(id, title, author, genre, available);
                    return;
                }

                BookNode newNode = new BookNode(id, title, author, genre, available);
                newNode.Next = temp.Next;
                newNode.Prev = temp;
                temp.Next.Prev = newNode;
                temp.Next = newNode;
            }



            //Remove a book by Book ID.
            public void RemoveByBookId(int id)
            {
                BookNode temp = head;

                while (temp != null)
                {
                    if (temp.BookId == id)
                    {
                        if (temp == head)
                            head = temp.Next;
                        if (temp == tail)
                            tail = temp.Prev;
                        if (temp.Prev != null)
                            temp.Prev.Next = temp.Next;
                        if (temp.Next != null)
                            temp.Next.Prev = temp.Prev;

                        Console.WriteLine("Book removed successfully.");
                        return;
                    }
                    temp = temp.Next;
                }

                Console.WriteLine("Book not found.");
            }



            //Search for a book by Book Title.
            public void SearchByTitle(string title)
            {
                BookNode temp = head;
                bool found = false;

                while (temp != null)
                {
                    if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                    {
                        DisplayBook(temp);
                        found = true;
                    }
                    temp = temp.Next;
                }

                if (!found)
                    Console.WriteLine("Book not found.");
            }



            ////Search for a book by Book author.
            public void SearchByAuthor(string author)
            {
                BookNode temp = head;
                bool found = false;

                while (temp != null)
                {
                    if (temp.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
                    {
                        DisplayBook(temp);
                        found = true;
                    }
                    temp = temp.Next;
                }

                if (!found)
                    Console.WriteLine("No books found for this author.");
            }




            //Update a book’s Availability Status.
            public void UpdateAvailability(int id, bool available)
            {
                BookNode temp = head;

                while (temp != null)
                {
                    if (temp.BookId == id)
                    {
                        temp.IsAvailable = available;
                        Console.WriteLine("Availability updated successfully.");
                        return;
                    }
                    temp = temp.Next;
                }

                Console.WriteLine("Book not found.");
            }



            //Display all books in forward order.
            public void DisplayForward()
            {
                if (head == null)
                {
                    Console.WriteLine("Library is empty.");
                    return;
                }

                BookNode temp = head;
                while (temp != null)
                {
                    DisplayBook(temp);
                    temp = temp.Next;
                }
            }



            // //Display all books in reverse order.
            public void DisplayReverse()
            {
                if (tail == null)
                {
                    Console.WriteLine("Library is empty.");
                    return;
                }

                BookNode temp = tail;
                while (temp != null)
                {
                    DisplayBook(temp);
                    temp = temp.Prev;
                }
            }



            //Count the total number of books in the library.
            public void CountBooks()
            {
                int count = 0;
                BookNode temp = head;

                while (temp != null)
                {
                    count++;
                    temp = temp.Next;
                }

                Console.WriteLine($"Total number of books: {count}");
            }

            private void DisplayBook(BookNode book)
            {
                string status = book.IsAvailable ? "Available" : "Issued";
                Console.WriteLine($"ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Status: {status}");
            }
        }

        //MAIN CLASS
        class LibraryManagementSystem
        {
            //MAIN METHOD
            public static void Main(string[] args)
            {
                Library library = new Library();

                library.AddAtEnd(201, "Kafan", "PremChand", "Fiction", true);
                library.AddAtBeginning(203, "Gunah ka Devta", "Dharamvir Bharti", "Fiction", true);
                library.AddAtPosition(2, 202, "1984", "hehehehe", "hahahaha", false);

                Console.WriteLine("Library Books in Forward order:");
                library.DisplayForward();
                Console.WriteLine();

                Console.WriteLine("Library Books in Reverse order:");
                library.DisplayReverse();
                Console.WriteLine();

                Console.WriteLine("Search by Author:");
                library.SearchByAuthor("George Orwell");
                Console.WriteLine();

                Console.WriteLine("Update Availability:");
                library.UpdateAvailability(201, false);
                Console.WriteLine();

                Console.WriteLine("Remove Book:");
                library.RemoveByBookId(202);
                Console.WriteLine();

                Console.WriteLine("Final Library:");
                library.DisplayForward();


                Console.WriteLine();
                library.CountBooks();
            }
        }
    }

}
