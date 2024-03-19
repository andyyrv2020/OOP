public class Pet
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public string Type { get; private set; }

    public Pet(string name, int age, string type)
    {
        Name = name;
        Age = age;
        Type = type;
    }
}