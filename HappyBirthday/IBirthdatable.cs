using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyBirthday
{
    internal interface IBirthdatable
    {
        DateTime Birthdate { get; }
        void PrintBirthdates(int year);
    }
}
