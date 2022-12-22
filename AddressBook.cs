using System;
using System.Collections.Generic;

namespace Ch16_AddressBook
{

    public class AddressBook
    {
        public string AddressBookName { get; set; }
        public List<Contact> Contacts { get; set; }
        // todo: make AddContact method to add contacts to address book
        //todo: what does void mean/do here?
        public AddContact(string name) //! you ned a return type, and it wwill work! try this video @ 11min in: https://www.youtube.com/watch?v=ArrHTifOY20
        {
            this.AddressBookName = name;
            Contacts = new List<Contact>();

        }
        // add a list contacts method: 
        public void ListContacts()
        {
            foreach (Contact contact in Contacts)
            {
                Console.WriteLine($"{contact.FirstName} {contact.LastName}'s email is {contact.Email}. They are stored in {AddressBookName}.");

            }

        }
        //todo: add GetByEmail method 
    }



}