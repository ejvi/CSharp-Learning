public class RandomNumberGenerator
{
    public static void Main(string[] args)
    {
        Random random = new Random(); // Create a single instance

        Console.WriteLine("Generating 5 random numbers:");
        for (int i = 0; i < 5; i++)
        {
            int num = random.Next(1, 999); // Numbers between 1 and 100
            Console.WriteLine($"Random number {i + 1}: {num}");
        }
    }
}