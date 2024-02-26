namespace ThreadsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread th1 = new Thread(CountBackwards);  
            Thread th2 = new Thread(CountBackwards);
            th1.Start();
            th2.Start();
        }
        static Random random = new Random();
        static void CountBackwards()
        {
            int waitTime = random.Next(1, 10) * 1000;
            Console.WriteLine($"Wait time: {waitTime}");

            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(waitTime);    
            }
        }

    }
}
