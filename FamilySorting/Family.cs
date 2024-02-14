using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilySorting
{
    internal class Family
    {
        private List<Person> members;

        public Family()
        {
            members = new List<Person>();
        }

        public void AddMember(Person member)
        {
            members.Add(member);
        }

        public Person GetOldestMember()
        {
            return members.OrderByDescending(p => p.Age).FirstOrDefault();
        }
    }
}
