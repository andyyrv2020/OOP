using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWorkerManagement
{
	class Student : Human
	{
		public double Grade { get; set; }
		public Student(string firstName, string lastName, double grade)
			: base(firstName, lastName)
		{
			Grade = grade;
		}
	}
}
