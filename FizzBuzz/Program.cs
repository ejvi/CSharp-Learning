int max = 100;

for (int i = 1; i <= max; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"{i} - FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}