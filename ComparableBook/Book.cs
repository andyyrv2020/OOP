using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableBook
{
    public class Book : IComparable<Book>
    {
        public Book(string title, int year, params string[] authors)
        {
            //this.Title = title;
            //this.Year = year;

        }
        public string Title { get; private set; }
        public int Year { get; private set;}
        public IReadOnlyList<string> Authors { get; private set; }
            
        public int CompareTo(Book other)
        {
            int result = this.Year.CompareTo(other.Year);
            if (result == 0)
            {
                result = this.Title.CompareTo(other.Title);
                return result;
            }
            return other; 
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}"; 
        }

        public class BookComparator : IComparer<Book>
        {
           public int Compare(Book x, Book y)
            {
                int result = x.Title.CompareTo(y.Title);
                if (result == 0)
                {
                    result = y.Year.CompareTo(x.Year);
                }

                return result;
            }
        }
    }
}
