namespace ComparableObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                List<Person> people = new List<Person>();

                string input;
                while ((input = Console.ReadLine()) != "END")
                {
                    string[] tokens = input.Split();
                    string name = tokens[0];
                    int age = int.Parse(tokens[1]);
                    string city = tokens[2];
                    people.Add(new Person { Name = name, Age = age, City = city });
                }

                int N = int.Parse(Console.ReadLine());

                Person selectedPerson = people[N - 1];
                int sameCount = 0;
                int differentCount = 0;

                foreach (var person in people)
                {
                    int comparison = selectedPerson.CompareTo(person);
                    if (comparison == 0)
                        sameCount++;
                    else
                        differentCount++;
                }

                if (sameCount == 0)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine($"{sameCount} {differentCount} {people.Count}");
                }
            }
        }
    }
}