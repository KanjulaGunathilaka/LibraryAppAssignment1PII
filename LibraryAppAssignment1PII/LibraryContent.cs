using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppAssignment1PII
{
    internal class LibraryContent
    {
        public string Title { get; set; }
        public string Type { get; set; }
        public bool Borrowed { get; set; }

        public LibraryContent(string title, string type)
        {
            Title = title;
            Type = type;
            Borrowed = false;
        }
        public bool IsBorrowed()
        {
            return Borrowed;
        }
        public override string ToString()
        {
            return $"{Title} ({Type})";
        }
    }

}
