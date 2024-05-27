using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var guests = Console.ReadLine().Split().ToList();
        var filters = new List<(string, string)>();
        string command;

        while ((command = Console.ReadLine()) != "Print")
        {
            var cmdParts = command.Split(';');
            string action = cmdParts[0];
            string filterType = cmdParts[1];
            string parameter = cmdParts[2];

            if (action == "Add filter")
            {
                filters.Add((filterType, parameter));
            }
            else if (action == "Remove filter")
            {
                filters.Remove((filterType, parameter));
            }
        }

        foreach (var (filterType, parameter) in filters)
        {
            guests = guests.Where(g => !MatchCriteria(g, filterType, parameter)).ToList();
        }

        Console.WriteLine(string.Join(" ", guests));
    }

    static bool MatchCriteria(string guest, string filterType, string parameter)
    {
        return filterType switch
        {
            "Starts with" => guest.StartsWith(parameter),
            "Ends with" => guest.EndsWith(parameter),
            "Length" => guest.Length == int.Parse(parameter),
            "Contains" => guest.Contains(parameter),
            _ => false,
        };
    }
}
    