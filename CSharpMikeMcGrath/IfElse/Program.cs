﻿Console.Title = "IfElse";

Console.Write("Please Enter A Number: ");
double num = Convert.ToDouble(Console.ReadLine());
Console.Write("Thanks. Now Enter A Letter: ");
char letter = Convert.ToChar(Console.ReadLine());

if (num >= 6)
{
    Console.WriteLine("\nNumber Exceeds 5");
}
else
{
    Console.WriteLine("\nNumber Is 5 Or Less");
}
if (letter == 'C')
{
    Console.WriteLine("Letter Is 'C'");
}
Console.ReadKey();