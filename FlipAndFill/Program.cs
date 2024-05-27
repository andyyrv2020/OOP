using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();
        int divisor = int.Parse(Console.ReadLine());

        Predicate<int> predicate = num => num % divisor != 0;
        List<int> result = numbers.FindAll(predicate);

        Console.WriteLine(string.Join(" ", result));
    }
}
    