using System;
using AddressBookApp.Models;
using AddressBookApp.Services;
using AddressBookApp.Exceptions;

namespace AddressBookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAddressBookApplication();
        }

        private static void RunAddressBookApplication()
        {
            AddressBookService service = new AddressBookService();

            while (true)
            {
                PrintMenu();
                Console.Write("Enter your choice: ");

                try
                {
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            CreateAddressBook(service);
                            break;
                        case 2:
                            AddContact(service);
                            break;
                        case 3:
                            EditContact(service);
                            break;
                        case 4:
                            DeleteContact(service);
                            break;
                        case 5:
                            DisplayContacts(service);
                            break;
                        case 6:
                            SearchByCity(service);
                            break;
                        case 7:
                            SearchByState(service);
                            break;
                        case 8:
                            service.ViewPersonsByCity();
                            break;
                        case 9:
                            service.ViewPersonsByState();
                            break;
                        case 10:
                            service.CountByCity();
                            break;
                        case 11:
                            service.CountByState();
                            break;
                        case 12:
                            SortContactsByName(service);
                            break;
                        case 13:
                            Console.WriteLine("Exiting application...");
                            return;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid numeric choice.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        private static void PrintMenu()
        {
            Console.WriteLine("\n========= ADDRESS BOOK MENU =========");
            Console.WriteLine("1. Create Address Book");
            Console.WriteLine("2. Add Contact");
            Console.WriteLine("3. Edit Contact");
            Console.WriteLine("4. Delete Contact");
            Console.WriteLine("5. Display Contacts");
            Console.WriteLine("6. Search by City");
            Console.WriteLine("7. Search by State");
            Console.WriteLine("8. View Persons By City");
            Console.WriteLine("9. View Persons By State");
            Console.WriteLine("10. Count by City");
            Console.WriteLine("11. Count by State");
            Console.WriteLine("12. Sort Contacts by Name");
            Console.WriteLine("13. Exit");
            Console.WriteLine("====================================");
        }

        private static void CreateAddressBook(AddressBookService service)
        {
            Console.Write("Enter Address Book Name: ");
            string name = Console.ReadLine();

            try
            {
                service.CreateAddressBook(name);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void AddContact(AddressBookService service)
        {
            try
            {
                Console.Write("Enter Address Book Name: ");
                string bookName = Console.ReadLine();

                Contact<int> contact = ReadContactDetails();
                service.AddContact(bookName, contact);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void EditContact(AddressBookService service)
        {
            try
            {
                Console.Write("Enter Address Book Name: ");
                string bookName = Console.ReadLine();

                Console.Write("Enter Contact ID to Edit: ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter New Contact Details:");
                Contact<int> updatedContact = ReadContactDetails(id);

                service.EditContact(bookName, id, updatedContact);
            }
            catch (ContactNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid ID format.");
            }
        }

        private static void DeleteContact(AddressBookService service)
        {
            try
            {
                Console.Write("Enter Address Book Name: ");
                string bookName = Console.ReadLine();

                Console.Write("Enter Contact ID to Delete: ");
                int id = int.Parse(Console.ReadLine());

                service.DeleteContact(bookName, id);
            }
            catch (ContactNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid ID format.");
            }
        }

        private static void DisplayContacts(AddressBookService service)
        {
            try
            {
                Console.Write("Enter Address Book Name: ");
                string bookName = Console.ReadLine();

                service.DisplayContacts(bookName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void SearchByCity(AddressBookService service)
        {
            Console.Write("Enter City: ");
            string city = Console.ReadLine();
            service.SearchByCity(city);
        }

        private static void SearchByState(AddressBookService service)
        {
            Console.Write("Enter State: ");
            string state = Console.ReadLine();
            service.SearchByState(state);
        }

        private static void SortContactsByName(AddressBookService service)
        {
            Console.Write("Enter Address Book Name: ");
            string bookName = Console.ReadLine();

            try
            {
                service.SortContactsByName(bookName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Helper method to read contact details
        private static Contact<int> ReadContactDetails(int? fixedId = null)
        {
            int id;

            if (fixedId.HasValue)
            {
                id = fixedId.Value;
            }
            else
            {
                Console.Write("Enter ID: ");
                id = int.Parse(Console.ReadLine());
            }

            Console.Write("First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("City: ");
            string city = Console.ReadLine();

            Console.Write("State: ");
            string state = Console.ReadLine();

            Console.Write("Zip: ");
            string zip = Console.ReadLine();

            Console.Write("Phone Number: ");
            string phone = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            return new Contact<int>(id, firstName, lastName, address, city, state, zip, phone, email);
        }
    }
}
