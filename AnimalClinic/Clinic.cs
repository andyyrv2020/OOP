public class Clinic
{
    private Pet[] rooms;

    public string Name { get; private set; }
    public int RoomsCount { get; private set; }

    public Clinic(string name, int roomsCount)
    {
        Name = name;
        if (roomsCount % 2 == 0)
        {
            throw new ArgumentException("Number of rooms must be odd.");
        }
        RoomsCount = roomsCount;
        rooms = new Pet[roomsCount];
    }

    public bool AddPet(Pet pet)
    {
        int currentIndex = rooms.Length / 2;
        int shift = 0;
        while (true)
        {
            if (rooms[currentIndex] == null)
            {
                rooms[currentIndex] = pet;
                return true;
            }
            shift++;
            currentIndex = (currentIndex + (shift % 2 == 0 ? -shift : shift)) % rooms.Length;
            if (shift >= rooms.Length)
            {
                break; 
            }
        }
        return false;
    }

    public bool ReleasePet()
    {
        for (int i = 0; i < rooms.Length; i++)
        {
            if (rooms[i] != null)
            {
                rooms[i] = null;
                return true;
            }
        }
        return false;
    }

    public bool HasEmptyRooms()
    {
        foreach (Pet pet in rooms)
        {
            if (pet == null)
            {
                return true;
            }
        }
        return false;
    }

    public void Print(int? roomNumber = null)
    {
        if (roomNumber.HasValue)
        {
            int index = roomNumber.Value - 1;
            if (rooms[index] != null)
            {
                Console.WriteLine($"{rooms[index].Name} {rooms[index].Age} {rooms[index].Type}");
            }
            else
            {
                Console.WriteLine("Room empty");
            }
        }
        else
        {
            for (int i = 0; i < rooms.Length; i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine($"{rooms[i].Name} {rooms[i].Age} {rooms[i].Type}");
                }
                else
                {
                    Console.WriteLine("Room empty");
                }
            }
        }
    }
}