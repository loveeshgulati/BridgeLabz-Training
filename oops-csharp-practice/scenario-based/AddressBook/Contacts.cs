using BridgeLabz_Training;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;


namespace BridgeLabz_Training.AddressBook
{
    //UC1 : Ability to create a Contacts in AddressBook with first and last names, address,city, state, zip, phone number and email
    internal class Contacts
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string ZIP;
        public string State;
        public long PhoneNumber;
        public string Email;
        public void DisplayContact()
        {
            Console.WriteLine("\nContact Details:");
            Console.WriteLine("First Name   : " + FirstName);
            Console.WriteLine("Last Name    : " + LastName);
            Console.WriteLine("Address      : " + Address);
            Console.WriteLine("City         : " + City);
            Console.WriteLine("State        : " + State);
            Console.WriteLine("Zip          : " + ZIP);
            Console.WriteLine("Phone Number : " + PhoneNumber);
            Console.WriteLine("Email        : " + Email);
        }

    }
}
