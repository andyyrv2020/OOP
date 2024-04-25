using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTemplate
{
    class NameComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int nameLengthComparison = x.Name.Length.CompareTo(y.Name.Length);
            if (nameLengthComparison != 0)
                return nameLengthComparison;

            return string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase);
        }
    }
}
