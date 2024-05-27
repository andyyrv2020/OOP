using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Array.Sort(numbers, (x, y) =>
        {
            int result = (x % 2).CompareTo(y % 2);
            return result == 0 ? x.CompareTo(y) : result;
        });

        Console.WriteLine(string.Join(" ", numbers));
    }
}
