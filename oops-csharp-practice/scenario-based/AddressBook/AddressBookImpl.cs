using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace BridgeLabz_Training.AddressBook
{
    internal class AddressBookImpl : IAddressBook
    {
        private Contacts[] contactDetails = new Contacts[10];//UC 5 : Ability to add multiple person to Address Book
        private int count = 0;
        //UC 2 :Ability to add a new Contact to Address Book
        public void CreateContact()
        {
            if (count >= contactDetails.Length)
            {
                Console.WriteLine("Address book is full");
                return;
            }
            Contacts contact = new Contacts();
            Console.WriteLine("Welcome to Address Book Program");
            Console.WriteLine("Enter contact details");

            Console.Write("Enter First Name: ");
            contact.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            contact.LastName = Console.ReadLine();

            Console.Write("Enter Address: ");
            contact.Address = Console.ReadLine();

            Console.Write("Enter City: ");
            contact.City = Console.ReadLine();

            Console.Write("Enter State: ");
            contact.State = Console.ReadLine();

            Console.Write("Enter Zip: ");
            contact.ZIP = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter Email: ");
            contact.Email = Console.ReadLine();
            contactDetails[count] = contact;
            count++;
            Console.WriteLine("Contact Added successfully");

        }
        // UC 3 : Ability to edit existing contact person using their name
        public void EditContact(string name)
        {
            for (int i = 0; i < count; i++)
            {
                if (contactDetails[i].FirstName.Equals(name))
                {
                    Console.WriteLine("\nEditing Contact: " + name);

                    Console.Write("Enter New Address: ");
                    contactDetails[i].Address = Console.ReadLine();

                    Console.Write("Enter New City: ");
                    contactDetails[i].City = Console.ReadLine();

                    Console.Write("Enter New State: ");
                    contactDetails[i].State = Console.ReadLine();

                    Console.Write("Enter New Zip: ");
                    contactDetails[i].ZIP = Console.ReadLine();

                    Console.Write("Enter New Phone Number: ");
                    contactDetails[i].PhoneNumber = Convert.ToInt64(Console.ReadLine());

                    Console.Write("Enter New Email: ");
                    contactDetails[i].Email = Console.ReadLine();

                    Console.WriteLine("Contact Updated Successfully!");

                    contactDetails[i].DisplayContact();
                    return;
                }
            }
            Console.WriteLine("Contact with given name not found.");
        }
        public void DeleteContact(string name)
        {
            for (int i = 0; i < count; i++)
            {
                if (contactDetails[i].FirstName.Equals(name))
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        contactDetails[j] = contactDetails[j + 1];
                    }
                    contactDetails[count - 1] = null;
                    count--;
                    Console.WriteLine("Contact deleted succesfully");
                    return;
                }

                Console.WriteLine("Contact not found");
            }
        }
        public void DisplayAllContact()
        {
            if (count == 0)
            {
                Console.WriteLine("\nNo contacts available.");
                return;
            }

            Console.WriteLine("\nAll Contacts:");
            for (int i = 0; i < count; i++)
            {
                contactDetails[i].DisplayContact();
            }
        }

    }

}


