using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AnimalFarm
{
	internal class Food
	{
		public int Quantity { get; set; }
		public string Vegetable { get; set; }
		public string Meat { get; set; }

		public Food(string vegetable, string meat)
		{
			Vegetable	 = vegetable;
			Meat = meat;
		}
	}
}
