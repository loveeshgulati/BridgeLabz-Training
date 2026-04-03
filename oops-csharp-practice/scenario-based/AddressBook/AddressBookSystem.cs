using BridgeLabz_Training.OOPS.BookBuddy;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace BridgeLabz_Training.AddressBook
{
    class AddressBookSystem : IAddressBookSystem
    {
        private AddressBookImpl[] books = new AddressBookImpl[5];
        private int count = 0;

        public void CreateAddressBook()
        {
            Console.Write("Enter Address Book Name: ");
            string name = Console.ReadLine();

            for (int i = 0; i < count; i++)
            {
                if (books[i].AddressBookName.Equals(name))
                {
                    Console.WriteLine("Address Book Already Exists!");
                    return;
                }
            }

            books[count++] = new AddressBookImpl(name);
            Console.WriteLine("Address Book Created!");
        }

        public AddressBookImpl GetAddressBook(string name)
        {
            for (int i = 0; i < count; i++)
                if (books[i].AddressBookName.Equals(name))
                    return books[i];
            return null;
        }

        public void DisplayAllAddressBooks()
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine(books[i].AddressBookName);
        }

        public void SearchPersonByCity(string city)
        {
            for (int i = 0; i < count; i++)
                books[i].SearchByCity(city);
        }

        public void SearchPersonByState(string state)
        {
            for (int i = 0; i < count; i++)
                books[i].SearchByState(state);
        }
        // UC9 – View Persons by City
        public void ViewPersonsByCity()
        {
            Console.WriteLine("\nPersons Grouped By City:");

            for (int i = 0; i < count; i++)
            {
                AddressBookImpl book = books[i];
                Contacts[] contacts = book.GetContacts();
                int total = book.GetCount();

                for (int j = 0; j < total; j++)
                {
                    Console.WriteLine($"City : {contacts[j].City}");
                    contacts[j].DisplayContact();
                }
            }
        }

        // UC9 – View Persons by State
        public void ViewPersonsByState()
        {
            Console.WriteLine("\nPersons Grouped By State:");

            for (int i = 0; i < count; i++)
            {
                AddressBookImpl book = books[i];
                Contacts[] contacts = book.GetContacts();
                int total = book.GetCount();

                for (int j = 0; j < total; j++)
                {
                    Console.WriteLine($"State : {contacts[j].State}");
                    contacts[j].DisplayContact();
                }
            }
        }
        public void CountByCity(string city)
        {
            int countPersons = 0;

            for (int i = 0; i < count; i++)
            {
                Contacts[] contacts = books[i].GetContacts();
                int total = books[i].GetCount();

                for (int j = 0; j < total; j++)
                {
                    if (contacts[j].City.Equals(city))
                        countPersons++;
                }
            }

            Console.WriteLine($"Total persons in City '{city}' : {countPersons}");
        }

        // UC10 – Count persons by State
        public void CountByState(string state)
        {
            int countPersons = 0;

            for (int i = 0; i < count; i++)
            {
                Contacts[] contacts = books[i].GetContacts();
                int total = books[i].GetCount();

                for (int j = 0; j < total; j++)
                {
                    if (contacts[j].State.Equals(state))
                        countPersons++;
                }
            }

            Console.WriteLine($"Total persons in State '{state}' : {countPersons}");
        }
    }
}

