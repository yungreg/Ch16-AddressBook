using System;
using System.Collections.Generic;

namespace Ch16_AddressBook
{
    class Program
    {
        /*
            1. Add the required classes to make the following code compile.
            HINT: Use a Dictionary in the AddressBook class to store Contacts. The key should be the contact's email address.

            2. Run the program and observe the exception.

            3. Add try/catch blocks in the appropriate locations to prevent the program from crashing
                Print meaningful error messages in the catch blocks.
        */
        /*
        *todo: create using statrement for teh list from generics
        todo: create contact class
        *todo: create address book class 
        todo: make AddContact method to add contatcts to address book
        */

        //todo*: create contact class
        public class Contact
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Address { get; set; }
        }

        //todo*: create address book class 

        public class AddressBook
        {
            // todo*: make contact dictionary that expects a key of a string & a Value of a string
            Dictionary<string, Contact> contacts = new Dictionary<string, Contact>();

            // todo: make AddContact method to add contacts to address book
            //todo: what does void mean/do here?
            public void AddContact(Contact contact)
            {
                this.Add(contact); //? how do i get this to .add to addressbook?
            }

            //todo: add GetByEmail method 
        }



        static void Main(string[] args)
        {



            // Create a few contacts
            Contact bob = new Contact()
            {
                FirstName = "Bob",
                LastName = "Smith",
                Email = "bob.smith@email.com",
                Address = "100 Some Ln, Testville, TN 11111"
            };
            Contact sue = new Contact()
            {
                FirstName = "Sue",
                LastName = "Jones",
                Email = "sue.jones@email.com",
                Address = "322 Hard Way, Testville, TN 11111"
            };
            Contact juan = new Contact()
            {
                FirstName = "Juan",
                LastName = "Lopez",
                Email = "juan.lopez@email.com",
                Address = "888 Easy St, Testville, TN 11111"
            };



            // Create an AddressBook and add some contacts to it
            AddressBook addressBook = new AddressBook();
            addressBook.AddContact(bob);
            addressBook.AddContact(sue);
            addressBook.AddContact(juan);

            // Try to add a contact a second time
            addressBook.AddContact(sue);


            // Create a list of emails that match our Contacts
            List<string> emails = new List<string>() {
            "sue.jones@email.com",
            "juan.lopez@email.com",
            "bob.smith@email.com",
        };

            // Insert an email that does NOT match a Contact
            emails.Insert(1, "not.in.addressbook@email.com");


            //  Search the AddressBook by email and print the information about each Contact
            foreach (string email in emails)
            {
                Contact contact = addressBook.GetByEmail(email);
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Name: {contact.FullName}");
                Console.WriteLine($"Email: {contact.Email}");
                Console.WriteLine($"Address: {contact.Address}");
            }
        }
    }
}

