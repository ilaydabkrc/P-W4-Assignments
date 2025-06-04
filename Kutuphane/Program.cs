using System;
using System.Collections.Generic;

namespace LibraryApp
{
    // Represents a Book with its details
    public class Book
    {
        // Title of the book
        public string Title { get; set; } = string.Empty;

        // Author's first name
        public string AuthorFirstName { get; set; } = string.Empty;

        // Author's last name
        public string AuthorLastName { get; set; } = string.Empty;

        // Number of pages in the book
        public int PageCount { get; set; }

        // Publisher of the book
        public string Publisher { get; set; } = string.Empty;

        // Date when the book record was created
        public DateTime RecordDate { get; set; }

        // Default constructor sets RecordDate to current date/time
        public Book()
        {
            RecordDate = DateTime.Now;
        }

        // Parameterized constructor to initialize all properties
        public Book(string title, string authorFirstName, string authorLastName, int pageCount, string publisher, DateTime recordDate)
        {
            Title = title;
            AuthorFirstName = authorFirstName;
            AuthorLastName = authorLastName;
            PageCount = pageCount;
            Publisher = publisher;
            RecordDate = recordDate;
        }

        // Prints book information to the console
        public void PrintInfo()
        {
            Console.WriteLine($"Book Title: {Title}, Author: {AuthorFirstName} {AuthorLastName}, Pages: {PageCount}, Publisher: {Publisher}, Recorded: {RecordDate:yyyy-MM-dd}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Initialize a list of books with some sample data
            List<Book> books = new List<Book>()
            {
                new Book("Bir Kitap", "Ahmet", "Yılmaz", 320, "Alfa Yayınları", new DateTime(2023, 5, 14)),
                new Book("Başka Bir Kitap", "Ayşe", "Karan", 215, "Beta Yayıncılık", new DateTime(2023, 6, 20)),
                new Book("Daha Başka Kitap", "Mehmet", "Demir", 450, "Gamma Yayınları", new DateTime(2023, 7, 1)),
                new Book("Son Kitap", "Elif", "Şahin", 275, "Delta Yayıncılık", new DateTime(2023, 4, 15)),
                new Book("Örnek Kitap", "Selin", "Yurt", 198, "Epsilon Yayınları", new DateTime(2023, 3, 22))
            };

            // Loop through each book and print its information
            foreach (Book book in books)
            {
                Console.WriteLine("---------------"); // Separator line
                book.PrintInfo(); // Call method to print book details
            }

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}


//Book bir sınıftır, her kitap için bir nesne (örnek) oluştururuz.

//new Book(...) ile bir nesne(instance) oluşturulur.

// PrintInfo() metodu ile kitap bilgileri ekrana yazdırılır.

//List<Book> ile kitaplar bir koleksiyonda tutulur.

