class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        LinkedList<int> list = new LinkedList<int>();

        for (int i = 0; i < N; i++)
        {
            string[] command = Console.ReadLine().Split();
            int number = int.Parse(command[1]);

            if (command[0] == "Add")
            {
                list.Add(number);
            }
            else if (command[0] == "Remove")
            {
                list.Remove(number);
            }
        }

        Console.WriteLine(list.Count);
        foreach (int item in list)
        {
            Console.Write(item + " ");
        }
    }
}