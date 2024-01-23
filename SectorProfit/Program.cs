static void Main(string[] args)
{
	string sector = Console.ReadLine();

	double row = double.Parse(Console.ReadLine());
	double col = double.Parse(Console.ReadLine());
	double totalSum = 0;
	switch (sector)
	{
		case "Sector A":
			totalSum = GetTotalProfit(row, col, 11.60);
			break;
		case "Sector B":
			totalSum = GetTotalProfit(row, col, 14.50);
			break;
		case "Sector C":
			totalSum = GetTotalProfit(row, col, 16.10);
			break;
		case "Sector D":
			totalSum = GetTotalProfit(row, col, 8.40);
			break;
	}
	Console.WriteLine($"{sector} profit is {totalSum:f2} lv.");
	static double GetTotalProfit(double row, double col, double price)
	{
		return row * col * price;
	}
}