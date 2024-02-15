using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace HappyBirthday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IBirthdatable> entities = new List<IBirthdatable>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();
                string type = tokens[0];

                if (type == "Citizen")
                {
                    if (tokens.Length >= 10)
                    {
                        string name = tokens[1];
                        int age = int.Parse(tokens[2]);
                        string id = tokens[3];
                        DateTime birthdate;
                        if (DateTime.TryParseExact(tokens[4], "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthdate))
                        {
                            entities.Add(new Citizen(name, age, id, birthdate));
                        }
                        else
                        {
                            Console.WriteLine("Invalid birthdate format (citizen)");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid data format (citizen)");
                    }
                }
                else if (type == "Robot")
                {
                    if (tokens.Length >= 8)
                    {
                        string model = tokens[1];
                        string id = tokens[2];
                        DateTime birthdate;
                        if (DateTime.TryParseExact(tokens[3], "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthdate))
                        {
                            entities.Add(new Robot(model, id, birthdate));
                        }
                        else
                        {
                            Console.WriteLine("Invalid birthdate format (citizen)");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid data format (citizen)");
                    }
                }

                if (type == "Pet")
                {
                    if (tokens.Length >= 3)
                    {
                        string name = tokens[1];
                        DateTime birthdate;
                        if (DateTime.TryParseExact(tokens[2], "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthdate))
                        {
                            entities.Add(new Pet(name, birthdate));
                        }
                        else
                        {
                            Console.WriteLine("Invalid birthdate format (citizen)");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid data format (citizen)");
                    }
                }
            }
            int year = int.Parse(Console.ReadLine());
            foreach (var entity in entities)
            {
                entity.PrintBirthdates(year);
            }
        }
    }
}