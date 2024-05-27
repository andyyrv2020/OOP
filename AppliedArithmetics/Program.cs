using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<int> Add(List<int> numbers)
    {
        return numbers.Select(x => x + 1).ToList();
    }

    static List<int> Multiply(List<int> numbers)
    {
        return numbers.Select(x => x * 2).ToList();
    }

    static List<int> Subtract(List<int> numbers)
    {
        return numbers.Select(x => x - 1).ToList();
    }

    static void PrintNumbers(List<int> numbers)
    {
        Console.WriteLine(string.Join(" ", numbers));
    }

    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        while (true)
        {
            string command = Console.ReadLine();

            if (command == "end")
            {
                break;
            }
            else if (command == "add")
            {
                numbers = Add(numbers);
            }
            else if (command == "multiply")
            {
                numbers = Multiply(numbers);
            }
            else if (command == "substract")
            {
                numbers = Subtract(numbers);
            }
            else if (command == "print")
            {
                PrintNumbers(numbers);
            }
        }
    }
}
