using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsInterface
{
    public class Seat : ICar
    {
        public string Model { get; private set; }
        public string Color { get; private set; }
        public Seat(string model, string color) {  Model = model; Color = color; }

        public string Start()
        {
            return $"Engine start";
        }

        public string Stop()
        {
            return $"Break";
        }
    }
}