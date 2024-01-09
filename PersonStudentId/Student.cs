using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonStudentId
{
	class Student : People
	{
		public int StudentId { get; set; }
		public double GradeAverage { get; set; }

		// Конструктор на класа Student
		public Student(string name, string personalId, int studentId, double gradeAverage)
			: base(name, personalId)
		{
			StudentId = studentId;
			GradeAverage = gradeAverage;
		}

		// Метод за извеждане на информация за студента
		public new void Display()
		{
			base.Display();
			Console.WriteLine($"Student ID: {StudentId}");
			Console.WriteLine($"Grade Average: {GradeAverage}");
		}
	}
}
