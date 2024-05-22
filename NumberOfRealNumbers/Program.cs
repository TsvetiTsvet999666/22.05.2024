namespace NumberOfRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of real numbers separated by spaces:");
            string input = Console.ReadLine();
            string[] parts = input.Split( );
            var counts = new SortedDictionary<double, int>();
            foreach (string part in parts)
            {
                double num = double.Parse(part);
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }
            }
            foreach (var num in counts.Keys)
            {
                Console.WriteLine($"{num} -> {counts[num]}");
            }

        }
    }
}
