using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.object_modeling
{
    class Book
    {
        public string Title;
        public string Author;

        //constructor
        public Book(string enterTitle, string enterAuthor)
        {
            this.Title = enterTitle;
            this.Author = enterAuthor;
        }
    }

    // Library class 
    class Library
    {
        public string LibraryName;
        public List<Book> Books;

        //constructor
        public Library(string libraryName)
        {
            this.LibraryName = libraryName;
            this.Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void ShowBooks()
        {
            Console.WriteLine("Library: " + LibraryName);

            foreach (Book book in Books)
            {
                Console.WriteLine(book.Title + " by " + book.Author);
            }

            Console.WriteLine();
        }
    }

    // MAIN CLASS
    class Aggregation
    {
        //MAIN METHOD
        public static void Main(String[] args)
        {

            Book book1 = new Book("Rich Dad", "Liss");
            Book book2 = new Book("Atomic ", "Jameso");


            Library library1 = new Library("Central");
            Library library2 = new Library("Gate 2 Library");


            library1.AddBook(book1);
            library1.AddBook(book2);

            library2.AddBook(book2);


            library1.ShowBooks();
            library2.ShowBooks();
        }
    }
}
