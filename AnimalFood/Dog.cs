using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFood
{
    internal class Dog : Animal
    {
        public Dog(string name, string favouriteFood)
        {
            base.Name = name;
            base.FavouriteFood = favouriteFood;
        }
        public override string ExplainMyself()
        {
            return base.ExplainMyself() + Environment.NewLine + "BARK";
        }
    }
}
