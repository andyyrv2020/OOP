namespace PersonStudentId
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Student student = new Student("Иван Иванов", "1234567890", 12345, 4.75);
			Console.WriteLine("Student Information:");
			student.Display();
		}
	}
}