﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsInterface
{
    internal class ICar
    {
        public string Model { get; }
        public string Color { get; }
        public void Start();
        public void Stop(); 


    }
}
