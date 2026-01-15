using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.AddressBook
{
    internal class AddressBookMenu
    {
        AddressBookImpl addressBook = new AddressBookImpl();
        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("1. Create Contact");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        addressBook.CreateContact();
                        break;

                    case 2:
                        Console.Write("Enter First Name to Edit: ");
                        string name = Console.ReadLine();
                        addressBook.EditContact(name);
                        break;

                    case 3:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
