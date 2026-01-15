using BridgeLabz_Training.OOPS.LoanBuddy;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace BridgeLabz_Training.AddressBook
{
    
    internal class AddressBookMain
    {
        static void Main(string[] args)
        {

            AddressBookMenu menu = new AddressBookMenu();
            menu.ShowMenu();
        }
    }
}
