using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
	internal class Animal
	{
		public string animalName { get; set; }
		public string animalType { get; set; }
		public double animalWeight { get; set; }
		public int foodEaten { get; set; }

		public void makeSound()
		{

		}
		public void eat(Food quantity)
		{

		}
	}	
}
