using System;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services;

namespace LibraryManagementSystem.Utilities
{
    public class Menu
    {
        public static void DisplayMenu(Library library)
        {
            while (true)
            {
                
                Console.WriteLine("\n===============================");
                Console.WriteLine("  Library Management System  ");
                Console.WriteLine("===============================");
                Console.WriteLine("| 1. Add Book               |");
                Console.WriteLine("| 2. Remove Book            |");
                Console.WriteLine("| 3. Search Book by Title   |");
                Console.WriteLine("| 4. List All Books         |");
                Console.WriteLine("| 5. Exit                   |");
                Console.WriteLine("===============================");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": 
                        HandleAddBook(library);
                        break;

                    case "2": 
                        HandleRemoveBook(library);
                        break;

                    case "3": 
                        HandleSearchBook(library);
                        break;

                    case "4": 
                        library.ListBooks();
                        break;

                    case "5": 
                        Console.WriteLine("Exiting...");
                        return;

                    default: 
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        private static void HandleAddBook(Library library)
        {
            Console.Write("Enter book type (Book/EBook): ");
            string type = Console.ReadLine();
            Console.Write("Enter title: ");
            string title = Console.ReadLine();
            Console.Write("Enter author: ");
            string author = Console.ReadLine();
            Console.Write("Enter ISBN: ");
            string isbn = Console.ReadLine();
            Console.Write("Is available? (true/false): ");
            bool available = bool.Parse(Console.ReadLine());
            int fileSize = 0;

            if (type.ToLower() == "ebook")
            {
                Console.Write("Enter file size in MB: ");
                fileSize = int.Parse(Console.ReadLine());
            }

            Book book = BookFactory.CreateBook(type, title, author, isbn, available, fileSize);
            library.AddBook(book);
        }

        private static void HandleRemoveBook(Library library)
        {
            Console.Write("Enter ISBN to remove: ");
            string removeIsbn = Console.ReadLine();
            library.RemoveBook(removeIsbn);
        }

        private static void HandleSearchBook(Library library)
        {
            Console.Write("Enter book title to search: ");
            string searchTitle = Console.ReadLine();
            Book foundBook = library.SearchByTitle(searchTitle);
            Console.WriteLine(foundBook != null ? foundBook.ToString() : "Book not found.");
        }
    }
}
