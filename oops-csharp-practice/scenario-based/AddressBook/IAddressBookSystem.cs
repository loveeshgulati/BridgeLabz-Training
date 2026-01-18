using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.AddressBook
{
    internal interface IAddressBookSystem
    {
        void CreateAddressBook();
        AddressBookImpl GetAddressBook(string name);
        void DisplayAllAddressBooks();
        void SearchPersonByCity(string city);
        void SearchPersonByState(string state);
        void ViewPersonsByCity();
        void ViewPersonsByState();
        void CountByCity(string city);
        void CountByState(string state);
    }
}
