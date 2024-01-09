namespace StudentWorkerManagement
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Student student = new Student("Иван", "Иванов", 4.5);
			Console.WriteLine($"Студент: {student.FirstName} {student.LastName}, Оценка: {student.Grade}");

			Worker worker = new Worker("Петър", "Петров", 10.50m, 40);
			Console.WriteLine($"Работник: {worker.FirstName} {worker.LastName}, Изчислена надница: {worker.CalculateHourlyEarnings()}");
			Console.ReadLine();
		}
	}
}