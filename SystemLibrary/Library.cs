using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLibrary
{
    public class Library
    {
        // List Book
        private List<Book> books = new List<Book>();

        // Method For Adding Books To The Library
        public void AddBook(Book book)
        {
            books.Add(book);
        }

        // Method For Borrowing a Book
        public void BorrowBook(string title)
        {
            foreach (var book in books)
            {
                if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase)) // Because It Isn't Case Sensitive
                {
                    if (book.IsAvailable)
                    {
                        book.IsAvailable = false;
                        Console.WriteLine($"You Have Successfully Borrowed '{book.Title}'.");
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, The Book '{book.Title}' Is Currently UnAvailable.");
                    }
                    return;
                }
            }
            Console.WriteLine($"Book '{title}' Not Found In The Library.");
        }

        // Method For Returning a Book
        public void ReturnBook(string title)
        {
            foreach (var book in books)
            {
                if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    if (!book.IsAvailable)
                    {
                        book.IsAvailable = true;
                        Console.WriteLine($"Thank You For Returning '{book.Title}'.");
                    }
                    else
                    {
                        Console.WriteLine($"The Book '{book.Title}' Was Not Borrowed.");
                    }
                    return;
                }
            }
            Console.WriteLine($"Book '{title}' Not Found In The Library.");
        }

        // Method To Display All Books
        public void DisplayAllBooks()
        {
            Console.WriteLine("\nBooks In Library:");
            foreach (var book in books)
            {
                book.DisplayBookInfo();
            }
        }
    }
}
