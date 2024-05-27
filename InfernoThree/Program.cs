using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var gems = Console.ReadLine().Split().Select(int.Parse).ToList();
        var filters = new List<(string, int)>();
        string command;

        while ((command = Console.ReadLine()) != "Forge")
        {
            var cmdParts = command.Split(';');
            string action = cmdParts[0];
            string filterType = cmdParts[1];
            int parameter = int.Parse(cmdParts[2]);

            if (action == "Exclude")
            {
                filters.Add((filterType, parameter));
            }
            else if (action == "Reverse")
            {
                filters.Remove((filterType, parameter));
            }
        }

        var excluded = new HashSet<int>();
        foreach (var (filterType, parameter) in filters)
        {
            for (int i = 0; i < gems.Count; i++)
            {
                if (MatchCriteria(gems, i, filterType, parameter))
                {
                    excluded.Add(i);
                }
            }
        }

        Console.WriteLine(string.Join(" ", gems.Where((_, index) => !excluded.Contains(index))));
    }

    static bool MatchCriteria(List<int> gems, int index, string filterType, int parameter)
    {
        int left = index > 0 ? gems[index - 1] : 0;
        int right = index < gems.Count - 1 ? gems[index + 1] : 0;
        int current = gems[index];

        return filterType switch
        {
            "Sum Left" => (left + current) == parameter,
            "Sum Right" => (current + right) == parameter,
            "Sum Left Right" => (left + current + right) == parameter,
            _ => false,
        };
    }
}
