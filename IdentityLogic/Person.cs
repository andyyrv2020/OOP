using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityLogic
{
    class Person : IEquatable<Person>

    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Person other = (Person)obj;
            return Name.Equals(other.Name, StringComparison.OrdinalIgnoreCase) && Age == other.Age;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Name.ToLower().GetHashCode();
                hash = hash * 23 + Age.GetHashCode();
                return hash;
            }
        }

        public bool Equals(Person other)
        {
            if (other == null)
            {
                return false;
            }

            return Name.Equals(other.Name, StringComparison.OrdinalIgnoreCase) && Age == other.Age;
        }
    }
}
