using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTransport
{
    class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumptionPerKm)
            : base(fuelQuantity, fuelConsumptionPerKm)
        {
        }

        public override void Drive(double distance, double increasedConsumption = 0)
        {
            base.Drive(distance, increasedConsumption);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
