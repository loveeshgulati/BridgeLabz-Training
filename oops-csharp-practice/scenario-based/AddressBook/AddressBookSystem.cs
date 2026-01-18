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

    }
}

