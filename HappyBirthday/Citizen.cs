using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyBirthday
{
    public class Citizen : IBirthdatable
    {
        public string Name { get; }
        public int Age { get; }
        public string Id { get; }
        public DateTime Birthdate { get; }
        
        public Citizen(string name, int age, string id, DateTime birthdate)
        {
            Name = name;
            Age = age;
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
