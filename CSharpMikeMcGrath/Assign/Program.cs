Console.Title = "Assign";

int a;
int b;

Console.Write("Assign Values: ");
Console.Write("\t a = " + (a = 8));
Console.WriteLine("\t b = " + (b = 4));

Console.Write("\n\nAdd and Assign: ");
Console.Write("\t a += b (8 += 4)\t a = " + (a += b));
Console.Write("\n\nSubtract and Assign: ");
Console.Write("\t a -= b (12 -= 4)\t a = " + (a -= b));
Console.Write("\n\nMultiply and Assign: ");
Console.Write("\t a *= b (8 *= 4)\t a = " + (a *= b));
Console.Write("\n\nDvivide and Assign: ");
Console.Write("\t a /= b (32 /= 4)\t a = " + (a /= b));
Console.Write("\n\nModulus and Assign: ");
Console.Write("\t a %= b (8 %= 4)\t a = " + (a %= b));
Console.ReadKey();