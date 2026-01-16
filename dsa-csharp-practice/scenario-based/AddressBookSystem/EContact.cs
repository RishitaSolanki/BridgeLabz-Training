using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.AddressBookSystem
{ 
        public class EContact: IAddressBook
        {
       
           public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }

        
            public void TakeInput()
            {
                Console.Write("Enter First Name: ");
                FirstName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                LastName = Console.ReadLine();

                Console.Write("Enter Address: ");
                Address = Console.ReadLine();

                Console.Write("Enter City: ");
                City = Console.ReadLine();

                Console.Write("Enter State: ");
                State = Console.ReadLine();

                Console.Write("Enter Zip: ");
                Zip = Console.ReadLine();

                Console.Write("Enter Phone Number: ");
                PhoneNumber = Console.ReadLine();

                Console.Write("Enter Email: ");
                Email = Console.ReadLine();
            }

        // UC2 - Edit Contact
        public void EditContact()
        {
            Console.Write("\nEnter First Name to edit contact: ");
            string name = Console.ReadLine();

            if (FirstName.Equals(name))
            {
                Console.WriteLine("\nEnter new details");

                Console.Write("Enter Address: ");
                Address = Console.ReadLine();

                Console.Write("Enter City: ");
                City = Console.ReadLine();

                Console.Write("Enter State: ");
                State = Console.ReadLine();

                Console.Write("Enter Zip: ");
                Zip = Console.ReadLine();

                Console.Write("Enter Phone Number: ");
                PhoneNumber = Console.ReadLine();

                Console.Write("Enter Email: ");
                Email = Console.ReadLine();

                Console.WriteLine("Contact updated successfully!");
            }


            else
            {
                Console.WriteLine("Contact not found.");
            }
        }



        public void DisplayContact()
            {
                Console.WriteLine("--Contact Details--");
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


