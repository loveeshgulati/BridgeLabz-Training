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
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string zIP;
        private string state;
        private long phoneNumber;
        private string email;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public string ZIP
        {
            get { return zIP; }
            set { zIP = value; }
        }
        public long PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

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
