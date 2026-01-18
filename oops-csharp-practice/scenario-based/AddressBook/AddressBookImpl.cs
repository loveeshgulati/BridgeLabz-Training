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
        private Contacts[] contacts = new Contacts[10];
        private int count = 0;

        public AddressBookImpl(string name)
        {
            AddressBookName = name;
        }

        
        private bool IsDuplicate(string firstName, string lastName)
        {
            for (int i = 0; i < count; i++)
            {
                if (contacts[i].FirstName.Equals(firstName) &&
                    contacts[i].LastName.Equals(lastName))
                    return true;
            }
            return false;
        }

       
        public void CreateContact()
        {
            if (count >= contacts.Length)
            {
                Console.WriteLine("Address Book is Full!");
                return;
            }

            Console.Write("First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();

            if (IsDuplicate(firstName, lastName))
            {
                Console.WriteLine("Duplicate Entry Found!");
                return;
            }

            Contacts contact = new Contacts();
            contact.FirstName = firstName;
            contact.LastName = lastName;

            Console.Write("Address: ");
            contact.Address = Console.ReadLine();

            Console.Write("City: ");
            contact.City = Console.ReadLine();

            Console.Write("State: ");
            contact.State = Console.ReadLine();

            Console.Write("ZIP: ");
            contact.ZIP = Console.ReadLine();

            Console.Write("Phone: ");
            contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());

            Console.Write("Email: ");
            contact.Email = Console.ReadLine();

            contacts[count++] = contact;
            Console.WriteLine("Contact Added Successfully!");
        }

        
        public void EditContact(string name)
        {
            for (int i = 0; i < count; i++)
            {
                if (contacts[i].FirstName.Equals(name))
                {
                    Console.Write("New Address: ");
                    contacts[i].Address = Console.ReadLine();

                    Console.Write("New City: ");
                    contacts[i].City = Console.ReadLine();

                    Console.Write("New State: ");
                    contacts[i].State = Console.ReadLine();

                    Console.Write("New ZIP: ");
                    contacts[i].ZIP = Console.ReadLine();

                    Console.Write("New Phone: ");
                    contacts[i].PhoneNumber = Convert.ToInt64(Console.ReadLine());

                    Console.Write("New Email: ");
                    contacts[i].Email = Console.ReadLine();

                    Console.WriteLine("Contact Updated!");
                    return;
                }
            }
            Console.WriteLine("Contact Not Found.");
        }

       
        public void DeleteContact(string name)
        {
            for (int i = 0; i < count; i++)
            {
                if (contacts[i].FirstName.Equals(name))
                {
                    for (int j = i; j < count - 1; j++)
                        contacts[j] = contacts[j + 1];

                    contacts[--count] = null;
                    Console.WriteLine("Contact Deleted!");
                    return;
                }
            }
            Console.WriteLine("Contact Not Found.");
        }

        public void DisplayAllContact()
        {
            if (count == 0)
            {
                Console.WriteLine("No Contacts Available.");
                return;
            }

            for (int i = 0; i < count; i++)
                contacts[i].DisplayContact();
        }

        
        public void SearchByCity(string city)
        {
            for (int i = 0; i < count; i++)
                if (contacts[i].City.Equals(city))
                    contacts[i].DisplayContact();
        }

        public void SearchByState(string state)
        {
            for (int i = 0; i < count; i++)
                if (contacts[i].State.Equals(state))
                    contacts[i].DisplayContact();
        }

    }
}


