namespace StrategyTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            SortedSet<Person> nameSortedSet = new SortedSet<Person>(new NameComparer());
            SortedSet<Person> ageSortedSet = new SortedSet<Person>(new AgeComparer());

            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person { Name = name, Age = age };

                nameSortedSet.Add(person);
                ageSortedSet.Add(person);
            }

            Console.WriteLine("Names:");
            foreach (var person in nameSortedSet)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }

            Console.WriteLine("Ages:");
            foreach (var person in ageSortedSet)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }
        }
    }
}