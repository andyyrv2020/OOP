using System;
using System.Collections.Generic;

namespace RebelFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<IBuyer> buyers = new List<IBuyer>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (input.Length == 4)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string id = input[2];
                    DateTime birthdate = DateTime.Parse(input[3]);
                    buyers.Add(new Citizen(name, age, id, birthdate));
                }
                else if (input.Length == 3)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string group = input[2];
                    buyers.Add(new Rebel(name, age, group));
                }
            }
            string inputName= Console.ReadLine();
            while (inputName != "End")
            {
                foreach (var buyer in buyers)
                {
                    if (buyer is Citizen && ((Citizen)buyer).Name == inputName)
                    {
                        buyer.BuyFood();
                    }
                    else if (buyer is Rebel && ((Rebel)buyer).Name == inputName)
                    {
                        buyer.BuyFood();
                    }
                }
            }
            int totalFood = 0;
            foreach (var buyer in buyers)
            {
                totalFood += buyer.Food;
            }

            Console.WriteLine(totalFood);
        }
    }
}
