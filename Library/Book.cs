using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public string Title { get; }
        public int Year { get; }
        public List<string> Authors { get; }

        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = new List<string>(authors);
        }
    }
}
