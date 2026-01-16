using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.AddressBook
{
    class AddressBookMenu
    {
        AddressBookSystem system = new AddressBookSystem();

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n1. Create Address Book");
                Console.WriteLine("2. Add Contact to Address Book");
                Console.WriteLine("3. Edit Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Display Contacts of Address Book");
                Console.WriteLine("6. Display All Address Books");
                Console.WriteLine("7. Exit");
                Console.Write("Choose option: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        system.CreateAddressBook();
                        break;

                    case 2:
                        Console.Write("Enter Address Book name: ");
                        AddressBookImpl addBook = system.GetAddressBook(Console.ReadLine());
                        if (addBook != null) addBook.CreateContact();
                        else Console.WriteLine("Address Book not found");
                        break;

                    case 3:
                        Console.Write("Enter Address Book name: ");
                        AddressBookImpl editBook = system.GetAddressBook(Console.ReadLine());
                        if (editBook != null)
                        {
                            Console.Write("Enter First Name to edit: ");
                            editBook.EditContact(Console.ReadLine());
                        }
                        else Console.WriteLine("Address Book not found");
                        break;

                    case 4:
                        Console.Write("Enter Address Book name: ");
                        AddressBookImpl delBook = system.GetAddressBook(Console.ReadLine());
                        if (delBook != null)
                        {
                            Console.Write("Enter First Name to delete: ");
                            delBook.DeleteContact(Console.ReadLine());
                        }
                        else Console.WriteLine("Address Book not found");
                        break;

                    case 5:
                        Console.Write("Enter Address Book name: ");
                        AddressBookImpl viewBook = system.GetAddressBook(Console.ReadLine());
                        if (viewBook != null) viewBook.DisplayAllContact();
                        else Console.WriteLine("Address Book not found");
                        break;

                    case 6:
                        system.DisplayAllAddressBooks();
                        break;

                    case 7:
                        return;
                }
            }
        }
    }
}
