namespace ThreadsCarProduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductionLine line = new ProductionLine();

            line.StartProduction();

            Console.ReadLine();
        }
    }
}
