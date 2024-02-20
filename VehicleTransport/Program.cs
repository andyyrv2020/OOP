namespace VehicleTransport
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split();
            Car car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));

            string[] truckInfo = Console.ReadLine().Split();
            Truck truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine().Split();
                string command = commandArgs[0];
                double value = double.Parse(commandArgs[2]);

                switch (command)
                {
                    case "Drive":
                        double distance = double.Parse(commandArgs[3]);
                        if (commandArgs[1] == "Car")
                        {
                            car.Drive(distance, increasedConsumption: 0.9);
                        }
                        else if (commandArgs[1] == "Truck")
                        {
                            truck.Drive(distance, increasedConsumption: 1.6);
                        }
                        break;
                    case "Refuel":
                        if (commandArgs[1] == "Car")
                        {
                            car.Refuel(value);
                        }
                        else if (commandArgs[1] == "Truck")
                        {
                            truck.Refuel(value * 0.95);
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}
