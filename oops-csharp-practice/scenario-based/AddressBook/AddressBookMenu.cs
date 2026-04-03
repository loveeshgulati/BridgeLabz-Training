using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.AddressBook
{
    class AddressBookMenu
    {
        IAddressBookSystem system = new AddressBookSystem();

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n1.Create Address Book");
                Console.WriteLine("2.Add Contact");
                Console.WriteLine("3.Edit Contact");
                Console.WriteLine("4.Delete Contact");
                Console.WriteLine("5.Display Contacts");
                Console.WriteLine("6.Search by City");
                Console.WriteLine("7.Search by State");
                Console.WriteLine("8. View Persons By City");
                Console.WriteLine("9. View Persons By State");
                Console.WriteLine("10. Count by City");
                Console.WriteLine("11. Count by State");
                Console.WriteLine("12. Sort Contacts by Name");
                Console.WriteLine("13. Exit");


                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        system.CreateAddressBook();
                        break;

                    case 2:
                        Console.Write("Enter Address Book Name: ");
                        system.GetAddressBook(Console.ReadLine())?.CreateContact();
                        break;

                    case 3:
                        Console.Write("Enter Address Book Name: ");
                        var editBook = system.GetAddressBook(Console.ReadLine());
                        if (editBook != null)
                        {
                            Console.Write("Enter First Name: ");
                            editBook.EditContact(Console.ReadLine());
                        }
                        break;

                    case 4:
                        Console.Write("Enter Address Book Name: ");
                        var delBook = system.GetAddressBook(Console.ReadLine());
                        if (delBook != null)
                        {
                            Console.Write("Enter First Name: ");
                            delBook.DeleteContact(Console.ReadLine());
                        }
                        break;

                    case 5:
                        Console.Write("Enter Address Book Name: ");
                        system.GetAddressBook(Console.ReadLine())?.DisplayAllContact();
                        break;

                    case 6:
                        Console.Write("Enter City: ");
                        system.SearchPersonByCity(Console.ReadLine());
                        break;

                    case 7:
                        Console.Write("Enter State: ");
                        system.SearchPersonByState(Console.ReadLine());
                        break;

                    case 8:
                        system.ViewPersonsByCity();
                        break;

                    case 9:
                        system.ViewPersonsByState();
                        break;

                    case 10:
                        Console.Write("Enter City: ");
                        system.CountByCity(Console.ReadLine());
                        break;

                    case 11:
                        Console.Write("Enter State: ");
                        system.CountByState(Console.ReadLine());
                        break;

                    case 12:
                        Console.Write("Enter Address Book Name: ");
                        var sortBook = system.GetAddressBook(Console.ReadLine());
                        if (sortBook != null)
                            sortBook.SortByName();
                        else
                            Console.WriteLine("Address Book not found!");
                        break;
                    case 13:
                        return;
                }
            }
        }
    }
}
