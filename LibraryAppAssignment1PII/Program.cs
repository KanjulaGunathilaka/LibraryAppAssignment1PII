using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppAssignment1PII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example usage
            Library library = new Library();

            // Adding contents
            LibraryContent book1 = new LibraryContent("Book 1", "Book");
            LibraryContent article1 = new LibraryContent("Article 1", "Article");
            LibraryContent digitalMedia1 = new LibraryContent("Audio Book1", "DigitalMedia");
            library.AddContent(book1);
            library.AddContent(article1);

            // Listing contents
            library.ListContents();

            // Creating staff and student
            Staff staff = new Staff("Kanjula Gunathilaka");
            Student student = new Student("Sri Herath");

            // Borrowing contents
            staff.BorrowContent(book1);
            student.BorrowContent(article1);
            student.BorrowContent(digitalMedia1);

            // Listing borrowings
            staff.ListBorrowings();
            student.ListBorrowings();
            // Example penalty calculation
            DateTime returnDate = DateTime.Now.AddDays(3); // Assuming return date is 10 days in the future
            decimal studentPenalty = student.CalculatePenalty(returnDate);
            Console.WriteLine($"Penalty for Student: ${studentPenalty}");
        }
    }
}
