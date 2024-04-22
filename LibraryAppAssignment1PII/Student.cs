using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppAssignment1PII
{
    internal class Student:User
    {
        public int TrimesterBorrowed { get; set; }

        public Student(string name) : base(name)
        {
            TrimesterBorrowed = 0;
        }

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
