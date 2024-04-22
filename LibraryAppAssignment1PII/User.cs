using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppAssignment1PII
{
    internal class User
    {
        public string Name { get; set; }
        public List<LibraryContent> Borrowings { get; set; }

        public User(string name)
        {
            Name = name;
            Borrowings = new List<LibraryContent>();
        }

        public void BorrowContent(LibraryContent content)
        {
            Borrowings.Add(content);
            content.Borrowed = true;
        }

        public void ReturnContent(LibraryContent content)
        {
            Borrowings.Remove(content);
            content.Borrowed = false;
        }

        public void ListBorrowings()
        {
            Console.WriteLine($"Borrowings for {Name}:");
            foreach (var content in Borrowings)
            {
                Console.WriteLine($"- {content}");
            }
        }

        // Calculate penalty for overdue items
        public decimal CalculatePenalty(DateTime returnDate)
        {
            decimal penalty = 0;
            foreach (var content in Borrowings)
            {
                if (returnDate > DateTime.Now && content.IsBorrowed())
                {
                    TimeSpan overdue = returnDate - DateTime.Now;
                    penalty += (decimal)(overdue.Days * 5);
                }
            }
            return penalty;
        }
    }
}
