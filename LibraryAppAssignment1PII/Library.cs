using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppAssignment1PII
{
    internal class Library
    {
        public List<LibraryContent> Contents { get; set; }

        public Library()
        {
            Contents = new List<LibraryContent>();
        }

        public void AddContent(LibraryContent content)
        {
            Contents.Add(content);
        }

        public void RemoveContent(LibraryContent content)
        {
            Contents.Remove(content);
        }

        public void ListContents()
        {
            Console.WriteLine("Library Contents:");
            foreach (var content in Contents)
            {
                Console.WriteLine($"- {content}");
            }
        }
    }
}
