using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWorkerManagement
{
	class Human
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public Human(string firstName, string lastName)
		{
			FirstName = firstName;
			LastName = lastName;
		}
	}
}
