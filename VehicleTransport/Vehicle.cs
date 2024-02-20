using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTransport
{
    class Vehicle
    {
        protected double fuelQuantity;
        protected double fuelConsumptionPerKm;

        public Vehicle(double fuelQuantity, double fuelConsumptionPerKm)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public virtual void Drive(double distance, double increasedConsumption = 0)
        {
            double neededFuel = (this.fuelConsumptionPerKm + increasedConsumption) * distance;
            if (neededFuel <= this.fuelQuantity)
            {
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
                this.fuelQuantity -= neededFuel;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
        }

        public void Refuel(double liters)
        {
            this.fuelQuantity += liters;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.fuelQuantity:F2}";
        }
    }
}
