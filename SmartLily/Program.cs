using System;

namespace SmartLily
{
	class Program
	{
		static void Main(string[] args)
		{
			int age = int.Parse(Console.ReadLine());
			double priceWM = double.Parse(Console.ReadLine());
			int toysPrice = int.Parse(Console.ReadLine());
			int moneyEven = 0;
			int moneyOdd = 0;
			int evenYears = 0;
			for (int i = 1; i <= age; i++)
			{
				if (i % 2 == 0)
				{
					evenYears++;
					moneyEven += (10 * evenYears) - 1;

				}
				else
				{
					moneyOdd += toysPrice;
				}
			}
			if (moneyEven + moneyOdd >= priceWM)
			{
				Console.WriteLine($"Yes! {Math.Abs(moneyOdd + moneyEven - priceWM)}");
			}
			else
			{
				Console.WriteLine($"No!{Math.Abs(moneyOdd + moneyEven - priceWM)}");
			}
		}
	}
}