﻿Console.Title = "Condition";

int a = 8;
int b = 3;

string verb = (a != 1) ? " are " : " is ";
Console.WriteLine("There" + verb + a + "\n");

string parity = (a % 2 != 0) ? " Odd " : " Even ";
Console.WriteLine(a + " is " + parity);
parity = (b % 2 != 0) ? " Odd " : " Even ";
Console.WriteLine(b + " is " + parity);

int max = (a > b) ? a : b;
Console.Write("\nMaximum is " + max);
Console.ReadKey();