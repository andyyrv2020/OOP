namespace AnimalKingdom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat myCat = new Cat();
            Dog myDog = new Dog();

            Trainer catTrainer = new Trainer(myCat);
            Trainer dogTrainer = new Trainer(myDog);

            Console.WriteLine("Cat Trainer:");
            catTrainer.Make();

            Console.WriteLine("\nDog Trainer:");
            dogTrainer.Make();
        }
    }
}