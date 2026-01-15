using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.AddressBook
{
    internal interface IAddressBook
    {
        void CreateContact();//UC 2
        void EditContact(string name);//UC 3
        void DeleteContact(string name);//UC 4
    }
}
