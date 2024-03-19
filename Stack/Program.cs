class Program
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            string[] tokens = input.Split(' ');
            if (tokens[0] == "Push")
            {
                int[] elementsToAdd = tokens[1].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                                .Select(int.Parse)
                                                .ToArray();
                foreach (int element in elementsToAdd)
                {
                    stack.Push(element);
                }
            }
            else if (tokens[0] == "Pop")
            {
                try
                {
                    Console.WriteLine(stack.Pop());
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }
}