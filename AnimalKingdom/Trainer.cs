using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class Trainer
    {
        private readonly IAnimal entity;

        public Trainer(IAnimal animal)
        {
            entity = animal;
        }

        public void Make()
        {
            entity.Perform();
        }
    }
}
