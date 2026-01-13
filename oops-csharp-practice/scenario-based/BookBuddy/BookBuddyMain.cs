using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.BookBuddy
{
    internal class BookBuddyMain
    {
        static void Main(string[] args)
        {
            BookBuddyMenu menu = new BookBuddyMenu();
            menu.ShowMenu();
        }
    }
}
