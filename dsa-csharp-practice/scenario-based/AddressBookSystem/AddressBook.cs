using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.AddressBookSystem
{
    public class AddressBook
    {
        public String bookName { get; set; }
        public EContact[] contacts { get; set; }

        public AddressBook(String bookName)
        {
            this.bookName = bookName;
            this.contacts = new EContact[1000];
        }
    }

}




