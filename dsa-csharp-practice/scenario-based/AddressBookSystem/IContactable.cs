using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.AddressBookSystem
{
    public interface IContactable
    {
        void AddContact(AddressBook addressBook, EContact contact);
        void EditContact(AddressBook addressBook, EContact contact, string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string eMail);
        EContact ShowContact(AddressBook addressbook, String searchName);
        void DeleteContact(AddressBook addressBook, EContact contact);

        void SortContacts(AddressBook addressBook);

    }
}
