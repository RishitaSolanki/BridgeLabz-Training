using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem.AddressBookSystem
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
            Console.WriteLine("---Details---");
            Console.WriteLine("Enter your First Name-" + FirstName);
            Console.WriteLine("Enter your Second Name-" + LastName);
            Console.WriteLine("Enter your Address-" + Address);
            Console.WriteLine("Enter your City-" + City);
            Console.WriteLine("Enter your State-" + State);
            Console.WriteLine("Enter your Phone Number-" + PhoneNumber);
            Console.WriteLine("Enter your Email-" + Email);
            Console.WriteLine("Zip-" + Zip);




        }
    }
}
