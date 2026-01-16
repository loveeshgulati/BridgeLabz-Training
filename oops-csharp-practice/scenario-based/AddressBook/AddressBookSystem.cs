using BridgeLabz_Training.OOPS.BookBuddy;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace BridgeLabz_Training.AddressBook
{
    //UC 6 : Refactor to add multiple Address Book to the System.Each Address Book has a unique Name
    class AddressBookSystem
    {
        private AddressBookImpl[] books = new AddressBookImpl[5];
        private int bookCount = 0;

        public void CreateAddressBook()
        {
            if (bookCount >= books.Length)
            {
                Console.WriteLine("Cannot create more Address Books.");
                return;
            }

            Console.Write("Enter unique Address Book name: ");
            string name = Console.ReadLine();

            for (int i = 0; i < bookCount; i++)
            {
                if (books[i].AddressBookName.Equals(name))
                {
                    Console.WriteLine("Address Book already exists");
                    return;
                }
            }

            books[bookCount++] = new AddressBookImpl(name);
            Console.WriteLine("Address Book created successfully!");
        }

        public AddressBookImpl GetAddressBook(string name)
        {
            for (int i = 0; i < bookCount; i++)
            {
                if (books[i].AddressBookName.Equals(name))
                    return books[i];
            }
            return null;
        }

        public void DisplayAllAddressBooks()
        {
            if (bookCount == 0)
            {
                Console.WriteLine("No Address Books available.");
                return;
            }

            Console.WriteLine("Available Address Books:");
            for (int i = 0; i < bookCount; i++)
                Console.WriteLine("- " + books[i].AddressBookName);
        }
    }
}
