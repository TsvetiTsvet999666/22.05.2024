namespace ImprovedPhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new SortedDictionary<string, string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                string[] parts = command.Split(' ');
                string action = parts[0];
                if (action == "A")
                {
                    string name = parts[1];
                    string phoneNumber = parts[2];
                    phoneBook[name] = phoneNumber; 
                }
                else if (action == "S")
                {
                    string name = parts[1];
                    if (phoneBook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phoneBook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                else if (action == "ListAll")
                {
                    Console.WriteLine($"В указателя има {phoneBook.Count} записани.");
                    Console.WriteLine("Списък по азбучен ред:");
                    foreach (var entry in phoneBook)
                    {
                        Console.WriteLine($"{entry.Key} -> {entry.Value}");
                    }
                }
            }
        }
    }
}
