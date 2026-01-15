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
                Console.WriteLine("1. Create Contact");//UC 2
                Console.WriteLine("2. Edit Contact");//UC 3
                Console.WriteLine("3. Delete Contact");//UC 4
                Console.WriteLine("4. Display All Contacts");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        addressBook.CreateContact();
                        break;

                    case 2:
                        Console.Write("Enter First Name to Edit: ");
                        string editName = Console.ReadLine();
                        addressBook.EditContact(editName);
                        break;
                    
                    case 3:
                        Console.Write("Enter First Name to Delete: ");
                        string deleteName = Console.ReadLine();
                        addressBook.DeleteContact(deleteName);
                        break;

                    case 4:
                        Console.WriteLine("Displaying All Contacts");
                        addressBook.DisplayAllContact();
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
