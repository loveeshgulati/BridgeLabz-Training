using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace BridgeLabz_Training.AddressBook
{
    //UC 2 :Ability to add a new Contact to Address Book
    internal class AddressBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            Console.WriteLine("Enter contact details");
            Contacts contactDetails = new Contacts();

            Console.Write("Enter First Name: ");
            contactDetails.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            contactDetails.LastName = Console.ReadLine();

            Console.Write("Enter Address: ");
            contactDetails.Address = Console.ReadLine();

            Console.Write("Enter City: ");
            contactDetails.City = Console.ReadLine();

            Console.Write("Enter State: ");
            contactDetails.State = Console.ReadLine();

            Console.Write("Enter Zip: ");
            contactDetails.ZIP = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            contactDetails.PhoneNumber = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter Email: ");
            contactDetails.Email = Console.ReadLine();

            contactDetails.DisplayContact();
        }
    }
}
