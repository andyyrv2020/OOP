using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        var names = Console.ReadLine().Split().ToList();

        Predicate<string> predicate = name => name.Length <= length;
        var result = names.FindAll(predicate);

        Console.WriteLine(string.Join(Environment.NewLine, result));
    }
}