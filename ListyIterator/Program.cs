class Program
{
    static void Main(string[] args)
    {
        string[] command = Console.ReadLine().Split();
        ListyIterator<string> listyIterator = new ListyIterator<string>(command[1..]);

        while ((command = Console.ReadLine().Split())[0] != "END")
        {
            try
            {
                switch (command[0])
                {
                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;
                    case "Print":
                        listyIterator.Print();
                        break;
                    case "PrintAll":
                        Console.WriteLine(string.Join(" ", listyIterator));
                        break;
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}