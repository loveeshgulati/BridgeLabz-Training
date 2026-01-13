using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BridgeLabz_Training.OOPS.BookBuddy
{
    internal class BookOperationsImpl:IOperations
    {
        private string[] BookShelf;
        private int count = 0;
        public BookOperationsImpl(int capacity)
        {
            BookShelf = new string[capacity];
            count = 0;
        }
        public void AddBook(string titleOfBook, string author)
        {
            if(count>=BookShelf.Length) { Console.WriteLine("Bookshelf is full");return; }
            BookShelf[count] = titleOfBook + " - " + author;
            count++;
            Console.WriteLine("Book Added successfully");
        }
        public void SortBooksAlphabetically()
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (string.Compare(BookShelf[i], BookShelf[j], true) > 0)
                    {
                        String temp = BookShelf[i];
                        BookShelf[i] = BookShelf[j];
                        BookShelf[j] = temp;
                    }
                }
            }
            Console.WriteLine("Books sorted alphabetically.");
        }
        public void DisplayBooks()
        {
            Console.WriteLine("\nBooks in your shelf:");
            for (int i = 0; i < count; i++)
            {
                string[] parts = BookShelf[i].Split(" - ");
                Console.WriteLine("Title: " + parts[0] + ", Author: " + parts[1]);
            }
        }
        public void SearchByAuthor(string author)
        {
            bool found = false;
            for(int i = 0; i < count; i++)
            {
                string[] parts = BookShelf[i].Split(" - ");
                string bookAuthor = parts[1];
                if(bookAuthor.Equals(author, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("title: " + parts[0] + " author is : " + parts[1]);
                    found = true; 
                }
            }
            if (!found)
            {
                Console.WriteLine("No books for this author");
            }
        }

    }
}
