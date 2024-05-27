using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var divisors = Console.ReadLine().Split().Select(int.Parse).ToList();

        List<int> result = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            bool divisible = divisors.All(d => i % d == 0);
            if (divisible)
            {
                result.Add(i);
            }
        }

        Console.WriteLine(string.Join(" ", result));
    }
}
