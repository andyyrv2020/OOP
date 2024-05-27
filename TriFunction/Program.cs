using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var names = Console.ReadLine().Split();

        Func<string, int, bool> isValidName = (name, threshold) => name.Sum(c => c) >= threshold;

        var result = names.FirstOrDefault(name => isValidName(name, n));

        Console.WriteLine(result);
    }
}
