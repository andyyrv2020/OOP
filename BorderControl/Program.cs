using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace BorderControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, bool> idValid = new();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input.Split(' ');
                _ = tokens.Length switch
                {
                    3 =>
                    ValidateAndStoreId(tokens[2], idValid),
                    2 =>
                    ValidateAndStoreId(tokens[1], idValid),
                    _ => throw new
                    InvalidOperationException("Invalid input format.")
                };
            }
            int fakeIdsCount = int.Parse(Console.ReadLine());

            foreach (var (id, isValid) in idValid)
            {
                if (!isValid)
                    Console.WriteLine(id);
            }
        }
        static bool ValidateAndStoreId(string id, Dictionary<string, bool> idValid)
        {
            if (!ValidateId(id))
                idValid[id] = false;
            return true;
        }
        static bool ValidateId(string id)
        {
            if (id.Length != 10 || !isDigitsOnly(id))
                return false;

            int sum = 0;
            for (int i = 0; i < id.Length - 1; i++)
            {
                int digit = id[i] - '0';
                _ = i % 2 == 0 ? sum += digit * 2 : sum += digit;
            }
            int lastDigit = sum % 10;
            int controlDigit = (10 - lastDigit) % 10;
            return controlDigit == id[9] - '0';
        }

        static bool isDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
    }
}