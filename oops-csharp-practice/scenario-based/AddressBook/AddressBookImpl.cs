using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.AddressBook
{
    internal class AddressBookImpl:IAddressBook
    {
        private Contacts contactDetails = new Contacts();
        //UC 2 :Ability to add a new Contact to Address Book
        public void CreateContact()
        {

            Console.WriteLine("Welcome to Address Book Program");
            Console.WriteLine("Enter contact details");

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
        }
        // UC 3 : Ability to edit existing contact person using their name
        public void EditContact(string name)
        {
            if (contactDetails.FirstName != null && contactDetails.FirstName.Equals(name))
            {
                Console.WriteLine("\nEditing Contact: " + name);

                Console.Write("Enter New Address: ");
                contactDetails.Address = Console.ReadLine();

                Console.Write("Enter New City: ");
                contactDetails.City = Console.ReadLine();

                Console.Write("Enter New State: ");
                contactDetails.State = Console.ReadLine();

                Console.Write("Enter New Zip: ");
                contactDetails.ZIP = Console.ReadLine();

                Console.Write("Enter New Phone Number: ");
                contactDetails.PhoneNumber = Convert.ToInt64(Console.ReadLine());

                Console.Write("Enter New Email: ");
                contactDetails.Email = Console.ReadLine();

                Console.WriteLine("Contact Updated Successfully!");
                contactDetails.DisplayContact();
            }
            else
            {
                Console.WriteLine("Contact with given name not found.");
            }
        }
    }
}
