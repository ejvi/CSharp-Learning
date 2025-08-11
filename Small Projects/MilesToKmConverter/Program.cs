Console.WriteLine("Enter the distance in miles:");

// Read the input from the user
string input = Console.ReadLine();

// Try to parse the input as a double
if (double.TryParse(input, out double miles))
{
    // Conversion factor: 1 mile = 1.60934 kilometers
    double kilometers = miles * 1.60934;

    Console.WriteLine($"{miles} miles is equal to {kilometers:F2} kilometers.");
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid number for miles.");
}

Console.ReadKey(); // Keep the console window open until a key is pressed
