using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.oops.LibraryManagementSystem
{
    
   public abstract class LibraryItem
    {
        private int itemId;
        private string title;
        private string author;
        private string borrowerData;

        public int ItemId { get { return itemId; } set { itemId = value; } }
        public string Title { get { return title; } set { title = value; } }
        public string Author { get { return author; } set { author = value; } }
        protected string BorrowerData { get { return borrowerData; } set { borrowerData = value; } }

        public LibraryItem(int id, string itemTitle, string itemAuthor)
        {
            this.itemId = id;
            this.title = itemTitle;
            this.author = itemAuthor;
            this.borrowerData = "";
        }

        
        public abstract int GetLoanDuration();

        public void GetItemDetails()
        {
            Console.WriteLine("ID: " + itemId + " | " + title + " by " + author);
            Console.WriteLine("Loan Duration: " + GetLoanDuration() + " days");
        }
    }
}
