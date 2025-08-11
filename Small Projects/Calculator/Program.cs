Console.WriteLine("Console Calculator in C#");
Console.WriteLine("------------------------");

double num1 = 0;
double num2 = 0;
string operation;

Console.Write("Enter first number: ");
num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter second number: ");
num2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Choose an operation (+, -, *, /): ");
operation = Console.ReadLine();

double result = 0;

switch (operation)
{
    case "+":
        result = num1 + num2;
        break;
    case "-":
        result = num1 - num2;
        break;
    case "*":
        result = num1 * num2;
        break;
    case "/":
        if (num2 != 0)
        {
            result = num1 / num2;
        }
        else
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return; // Exit if division by zero occurs
        }
        break;
    default:
        Console.WriteLine("Invalid operation.");
        return; // Exit if invalid operation
}

Console.WriteLine($"Result: {result}");
Console.WriteLine("Press any key to close the calculator.");
Console.ReadKey();