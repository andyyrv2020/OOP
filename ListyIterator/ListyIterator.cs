using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyIterator
{
    public class ListyIterator<T>
    {
        private List<T> collection;
        private int currentIndex;

        public ListyIterator(IEnumerable<T> collection)
        {
            this.collection = new List<T>(collection);
            this.currentIndex = 0;
        }

        public bool Move()
        {
            if (this.HasNext())
            {
                this.currentIndex++;
                return true;
            }
            return false;
        }

        public bool HasNext()
        {
            return this.currentIndex < this.collection.Count - 1;
        }

        public void Print()
        {
            if (this.collection.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(this.collection[this.currentIndex]);
        }
    }
}
