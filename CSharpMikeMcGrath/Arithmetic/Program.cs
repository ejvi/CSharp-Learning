Console.Title = "Arithmetic";

int a = 8;
int b = 4;

Console.WriteLine("Addition:\t " + (a + b));
Console.WriteLine("Substraction:\t " + (a - b));
Console.WriteLine("Multiplication:\t " + (a * b));
Console.WriteLine("Division:\t " + (a / b));
Console.WriteLine("Modulus:\t " + (a % b));

Console.WriteLine("\nPostfix Increment:\t " + (a++));
Console.WriteLine("\nPostfix Result.....\t " + a);

Console.WriteLine("\nPrefix Increment:\t " + (++b));
Console.WriteLine("\nPrefix Result.....\t " + b);