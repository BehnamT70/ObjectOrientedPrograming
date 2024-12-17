using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLibrary
{
    public class Book
    {
            // Propertise
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }
            public bool IsAvailable { get; set; }

            // Constructor
            public Book(string title, string author, string isbn, bool isavailable)
            {
                Title = title;
                Author = author;
                ISBN = isbn;
                IsAvailable = isavailable;
            }

            // Method To Display Infromaion Books
            public void DisplayBookInfo()
            {
                Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}, IsAvailable: {(IsAvailable ? "Available" : "UnAvailable")}");
            }
    }
}
