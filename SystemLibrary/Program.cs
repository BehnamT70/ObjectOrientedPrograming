namespace SystemLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library myLibrary = new Library();

            // Add a Book To The Library
            myLibrary.AddBook(new Book("Clean Code", "Robert Martins", "123-456789", true));
            myLibrary.AddBook(new Book("Design Patterns", "Erich Gamma", "987-654321", true));
            myLibrary.AddBook(new Book("Clean Architecture", "Robert Martins", "456-123987", true));

            // For Exit Program
            bool exit = false;

            while (!exit)
            {
                // Create Menu
                Console.WriteLine("\nLibrary Management System");
                Console.WriteLine("\n1. Display All Books");
                Console.WriteLine("2. Borrow a Book");
                Console.WriteLine("3. Return a Book");
                Console.WriteLine("4. Add a New Book");
                Console.WriteLine("5. Exit");
                Console.Write("Enter Your Choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        myLibrary.DisplayAllBooks();
                        Console.WriteLine("-------------------------------------------------------------------------------------------");
                        break;
                    case "2":
                        Console.Write("Enter The Title Of The Book To Borrow: ");
                        string borrowTitle = Console.ReadLine();
                        myLibrary.BorrowBook(borrowTitle);
                        Console.WriteLine("-------------------------------------------------------------------------------------------");
                        break;

                    case "3":
                        Console.Write("Enter The Title Of The Book To Return: ");
                        string returnTitle = Console.ReadLine();
                        myLibrary.ReturnBook(returnTitle);
                        Console.WriteLine("-------------------------------------------------------------------------------------------");
                        break;

                    case "4":
                        Console.Write("Enter The Title Of The New Book: ");
                        string newTitle = Console.ReadLine();
                        Console.Write("Enter The Author Of The New Book: ");
                        string newAuthor = Console.ReadLine();
                        Console.Write("Enter The ISBN Of The New Book: ");
                        string newISBN = Console.ReadLine();
                        myLibrary.AddBook(new Book(newTitle, newAuthor, newISBN, true));
                        Console.WriteLine("-------------------------------------------------------------------------------------------");
                        break;

                    case "5":
                        Console.WriteLine("Exiting The Program!");
                        exit = true;
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice. Please Enter a Number Between 1 and 5.");
                        Console.WriteLine("-------------------------------------------------------------------------------------------");
                        break;
                }
            }
        }
    }
}
