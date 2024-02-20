using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTransport
{
    class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumptionPerKm)
            : base(fuelQuantity, fuelConsumptionPerKm)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

}
