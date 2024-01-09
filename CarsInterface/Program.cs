namespace CarsInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICar Seat = new Seat("Leon", "Grey");
            ICar Tesla = new Tesla("Model 3", "Red", 2);

            Console.WriteLine(Seat.ToString());
            Console.WriteLine(Tesla.ToString());
        }
    }
}