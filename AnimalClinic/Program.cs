class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        Dictionary<string, Clinic> clinics = new Dictionary<string, Clinic>();

        for (int i = 0; i < N; i++)
        {
            string[] command = Console.ReadLine().Split();
            string action = command[0];

            try
            {
                switch (action)
                {
                    case "Create":
                        if (command[1] == "Pet")
                        {
                            string name = command[2];
                            int age = int.Parse(command[3]);
                            string type = command[4];
                            Pet pet = new Pet(name, age, type);
                            if (clinics.ContainsKey(command[5]))
                            {
                                Console.WriteLine(clinics[command[5]].AddPet(pet));
                            }
                            else
                            {
                                Console.WriteLine("Invalid Operation!");
                            }
                        }
                        else if (command[1] == "Clinic")
                        {
                            string name = command[2];
                            int roomsCount = int.Parse(command[3]);
                            clinics.Add(name, new Clinic(name, roomsCount));
                        }
                        break;
                    case "Add":
                        Console.WriteLine(clinics[command[2]].AddPet(new Pet(command[1], 0, "")));
                        break;
                    case "Release":
                        Console.WriteLine(clinics[command[1]].ReleasePet());
                        break;
                    case "HasEmptyRooms":
                        Console.WriteLine(clinics[command[1]].HasEmptyRooms());
                        break;
                    case "Print":
                        if (command.Length == 3)
                        {
                            clinics[command[1]].Print(int.Parse(command[2]));
                        }
                        else
                        {
                            clinics[command[1]].Print();
                        }
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Operation!");
            }
        }
    }
}
