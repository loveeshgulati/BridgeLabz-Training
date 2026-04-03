using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.AddressBook
{
    internal interface IAddressBook
    {
        void CreateContact();
        void EditContact(string name);
        void DeleteContact(string name);
        void DisplayAllContact();
        void SearchByCity(string city);
        void SearchByState(string state);
        void SortByName();
    }
}