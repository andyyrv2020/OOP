using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableObject
{
    internal class Person : IComparable<Person>
    {
        public string Name { get;  set; }
        public int Age { get;  set; }
        public string City { get; set; }
        public int CompareTo(Person other)
        {
            int nameComparison = Name.CompareTo(other.Name);
            if (nameComparison != 0)
                return nameComparison;

            int ageComparison = Age.CompareTo(other.Age);
            if (ageComparison != 0)
                return ageComparison;

            return City.CompareTo(other.City);
        }
    }
}
