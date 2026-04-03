using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.BookBuddy
{
    internal class Book
    {
        private string title;
        private string author;
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }
        public string Title
        {
            get { return title; } set { title = value; }
        }
        public string Author
            { get { return author; } set { author = value; } }
    }
}
