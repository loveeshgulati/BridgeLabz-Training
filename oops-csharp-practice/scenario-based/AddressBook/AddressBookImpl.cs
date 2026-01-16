using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace BridgeLabz_Training.AddressBook
{
    class AddressBookImpl : IAddressBook
    {
        public string AddressBookName;
        private Contacts[] contacts = new Contacts[10];//UC 5 : Ability to add multiple person to Address Book
        private int count = 0;

        public AddressBookImpl(string name)
        {
            AddressBookName = name;
        }
        //UC 2 :Ability to add a new Contact to Address Book
        public void CreateContact()
        {
            if (count >= contacts.Length)
            {
                Console.WriteLine("Address Book is full!");
                return;
            }

            Contacts contact = new Contacts();

            Console.Write("First Name: ");
            contact.FirstName = Console.ReadLine();

            Console.Write("Last Name: ");
            contact.LastName = Console.ReadLine();

            Console.Write("Address: ");
            contact.Address = Console.ReadLine();

            Console.Write("City: ");
            contact.City = Console.ReadLine();

            Console.Write("State: ");
            contact.State = Console.ReadLine();

            Console.Write("Zip: ");
            contact.ZIP = Console.ReadLine();

            Console.Write("Phone: ");
            contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());

            Console.Write("Email: ");
            contact.Email = Console.ReadLine();

            contacts[count++] = contact;
            Console.WriteLine("Contact added successfully!");
        }
        // UC 3 : Ability to edit existing contact person using their name
        public void EditContact(string name)
        {
            for (int i = 0; i < count; i++)
            {
                if (contacts[i].FirstName.Equals(name))
                {
                    Console.WriteLine("Editing contact: " + name);

                    Console.Write("New Address: ");
                    contacts[i].Address = Console.ReadLine();

                    Console.Write("New City: ");
                    contacts[i].City = Console.ReadLine();

                    Console.Write("New State: ");
                    contacts[i].State = Console.ReadLine();

                    Console.Write("New Zip: ");
                    contacts[i].ZIP = Console.ReadLine();

                    Console.Write("New Phone: ");
                    contacts[i].PhoneNumber = Convert.ToInt64(Console.ReadLine());

                    Console.Write("New Email: ");
                    contacts[i].Email = Console.ReadLine();

                    Console.WriteLine("Contact updated!");
                    return;
                }
            }
            Console.WriteLine("Contact not found.");
        }
        // UC 4 : Ability to delete a person using person's name 
        public void DeleteContact(string name)
        {
            for (int i = 0; i < count; i++)
            {
                if (contacts[i].FirstName.Equals(name))
                {
                    for (int j = i; j < count - 1; j++)
                        contacts[j] = contacts[j + 1];

                    contacts[count - 1] = null;
                    count--;

                    Console.WriteLine("Contact deleted successfully!");
                    return;
                }
            }
            Console.WriteLine("Contact not found.");
        }

        public void DisplayAllContact()
        {
            if (count == 0)
            {
                Console.WriteLine("No contacts in this Address Book.");
                return;
            }

            Console.WriteLine("\nContacts in Address Book : " + AddressBookName);
            for (int i = 0; i < count; i++)
                contacts[i].DisplayContact();
        }
    }

}


