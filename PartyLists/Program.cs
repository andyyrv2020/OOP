using System;
using System.Collections.Generic;
using System.Linq;

class PartyPlanner
{
    static void Main(string[] args)
    {
        List<string> guests = Console.ReadLine().Split().ToList();

        string command;
        while ((command = Console.ReadLine()) != "Party!")
        {
            var parts = command.Split();
            string action = parts[0];
            string criterionType = parts[1];
            string value = parts[2];

            Predicate<string> predicate = null;

            switch (criterionType)
            {
                case "StartsWith":
                    predicate = name => name.StartsWith(value);
                    break;
                case "EndsWith":
                    predicate = name => name.EndsWith(value);
                    break;
                case "Length":
                    int length = int.Parse(value);
                    predicate = name => name.Length == length;
                    break;
            }

            if (action == "Remove")
            {
                guests.RemoveAll(predicate);
            }
            else if (action == "Double")
            {
                List<string> guestsToDouble = guests.FindAll(predicate);
                guests.AddRange(guestsToDouble);
            }
        }

        if (guests.Count > 0)
        {
            Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");
        }
        else
        {
            Console.WriteLine("Nobody is going to the party!");
        }
    }
}
