using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyBirthday
{
    public class Pet : IBirthdatable
    {
        public string Name { get; }
        public DateTime Birthdate { get; }

        public Pet(string name, DateTime birthdate)
        {
            Name = name;
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
