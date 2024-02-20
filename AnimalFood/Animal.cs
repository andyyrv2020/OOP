using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFood
{
    internal class Animal
    {
        public string Name { get; protected set; }
        public string FavouriteFood { get; protected set; }
        public virtual string ExplainMyself()
        {
            return $"I am {this.Name} and my favourite food is {this.FavouriteFood}";
        }

    }
}