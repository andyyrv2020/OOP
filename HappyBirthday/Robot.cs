using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyBirthday
{
    public class Robot : IBirthdatable
    {
        public string Model { get; }
        public string Id { get; }
        public DateTime Birthdate { get; }

        public Robot(string model, string id, DateTime birthdate)
        {
            Model = model;
            Id = id;
            Birthdate = birthdate;
        }
        public void PrintBirthdates(int year)
        {
            if (Birthdate.Year == year)
            {
                Console.WriteLine(Birthdate.ToString("dd/MM/yyyy"));
            }
        }
    }
}
