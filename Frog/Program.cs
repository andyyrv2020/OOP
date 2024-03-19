class Program
{
    static void Main(string[] args)
    {
        var lakes = new List<IEnumerable<int>>
        {
            new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 },
            new List<int> { 1, 2, 3, 4 },
            new List<int> { 13, 23, 1, -8, 4, 9 }
        };

        foreach (var stones in lakes)
        {
            var lake = new Lake(stones);
            Console.WriteLine(string.Join(", ", lake));
        }
    }
}