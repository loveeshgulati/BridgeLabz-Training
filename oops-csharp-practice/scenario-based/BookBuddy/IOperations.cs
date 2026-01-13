using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.BookBuddy
{
    internal interface IOperations
    {
        void AddBook(string titleOfBook, string author);
        void SortBooksAlphabetically();
        void SearchByAuthor(string author);
    }
}
