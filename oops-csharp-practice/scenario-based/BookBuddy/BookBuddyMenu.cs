using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.BookBuddy
{
    class BookBuddyMenu
    {
        private BookOperationsImpl bookBuddy;

        public BookBuddyMenu()
        {
            bookBuddy = new BookOperationsImpl(10);
        }

        public void ShowMenu()
        {
            int choice;
            do
            {
                Console.WriteLine("\n=== BookBuddy – Digital Bookshelf ===");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. display book");
                Console.WriteLine("3. Sort Books Alphabetically");
                Console.WriteLine("4. Search Books by Author");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddBookMenu();
                        break;

                    case 2:
                    
                        bookBuddy.DisplayBooks();
                        break;

                    case 3:
                        bookBuddy.SortBooksAlphabetically();
                        break;

                    case 4:
                        SearchByAuthorMenu();
                        break;

                    case 0:
                        Console.WriteLine("Exiting BookBuddy. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

            } while (choice != 0);
        }

        private void AddBookMenu()
        {
            Console.Write("Enter Book Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Author Name: ");
            string author = Console.ReadLine();

            bookBuddy.AddBook(title, author);
        }

        private void SearchByAuthorMenu()
        {
            Console.Write("Enter Author to search: ");
            string author = Console.ReadLine();

            bookBuddy.SearchByAuthor(author);
        }

      
    }
}
