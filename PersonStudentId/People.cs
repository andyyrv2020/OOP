using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonStudentId
{
	internal class People
	{
		public string Name { get; set; }
		public string PersonId { get; set; }

		public People(string name, string personalId)
		{
			Name = name;
			PersonId = personalId;
		}

		public void Display()
		{
			Console.WriteLine($"Name: {Name}");
			Console.WriteLine($"Personal ID: {PersonId}");
		}
	}
}
