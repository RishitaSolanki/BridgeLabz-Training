using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.AddressBookSystem
{
    public class AddressBook : IAddressBook
    {
    private EContact[] contacts = new EContact[100];
    private int contactCount = 0; 

    
    public void AddContact()
    {
        if (contactCount >= contacts.Length)
        {
            Console.WriteLine("Address book full!");
            return;
        }

        EContact contact = new EContact();
        Console.Write("Enter First Name: ");
        contact.FirstName = Console.ReadLine();
        Console.Write("Enter Last Name: ");
        contact.LastName = Console.ReadLine();
        Console.Write("Enter Address: ");
        contact.Address = Console.ReadLine();
        Console.Write("Enter City: ");
        contact.City = Console.ReadLine();
        Console.Write("Enter State: ");
        contact.State = Console.ReadLine();
        Console.Write("Enter Zip: ");
        contact.Zip = Console.ReadLine();
        Console.Write("Enter Phone Number: ");
        contact.PhoneNumber = Console.ReadLine();
        Console.Write("Enter Email: ");
        contact.Email = Console.ReadLine();

        contacts[contactCount] = contact;
        contactCount++;

        Console.WriteLine("Contact added successfully!\n");
    }


    public void DisplayContact()
    {
        if (contactCount == 0)
        {
            Console.WriteLine("No contacts available.\n");
            return;
        }

        for (int i = 0; i < contactCount; i++)
        {
            contacts[i].DisplayContact();
        }
    }

    
    public EContact[] GetContactsArray()
    {
        return contacts;
    }

    public int GetContactCount()
    {
        return contactCount;
    }
}

}




