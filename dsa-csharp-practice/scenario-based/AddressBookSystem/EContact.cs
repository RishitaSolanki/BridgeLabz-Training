using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.AddressBookSystem
{
    public class EContact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public void DisplayContact()
        {

            Console.WriteLine("Display Contacts");

            Console.WriteLine("Name: " + FirstName + " " + LastName);

            Console.WriteLine("Address: " + Address);

            Console.WriteLine("City: " + City);

            Console.WriteLine("State: " + State);

            Console.WriteLine("Zip: " + Zip);

            Console.WriteLine("Phone: " + PhoneNumber);

            Console.WriteLine("Email: " + Email);
        }

    }
    }


