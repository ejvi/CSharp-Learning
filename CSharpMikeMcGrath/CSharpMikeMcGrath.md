```
Hello World
```
```c#
Console.WriteLine("Hello, World!");
Console.WriteLine("Good afternoon, GM!");
```
```
Hello, World!
Good afternoon, GM!
```

```
Variables
```
```c#
Console.Title = "Variables";

char letter; letter = 'A';
int number; number = 100;
float body = 98.7f;
double pi = 3.14159;
decimal sum = 1000.00m;
bool flag = false;
string text = "C# is fun";

Console.WriteLine("char letter:\t" + letter);
Console.WriteLine("int number:\t" + number);
Console.WriteLine("float body:\t" + body);
Console.WriteLine("double pi:\t" + pi);
Console.WriteLine("decimal sum:\t" + sum);
Console.WriteLine("bool flag:\t" + flag);
Console.WriteLine("string text:\t" + text);
Console.ReadKey();
```
```
char letter:    A
int number:     100
float body:     98,7
double pi:      3,14159
decimal sum:    1000,00
bool flag:      False
string text:    C# is fun
```

```
Input
```
```c#
Console.Title = "Input";

Console.WriteLine("Please enter your name:");
string name = Console.ReadLine();

Console.WriteLine("Welcome " + name + "!");
Console.ReadKey();
```
```
Please enter your name:
GM
Welcome GM!
```

```
Conversion
```
```c#
Console.Title = "Conversion";

Console.Write("Please Enter A Number: ");
double num = Convert.ToDouble(Console.ReadLine());
Console.Write("Now Enter Another Number: ");
double sum = num + Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Total= " + sum);
Console.ReadKey();
```
```
Please Enter A Number: 2
Now Enter Another Number: 7
Total= 9
```

```
Arrays
```
```c#
Console.Title = "Arrays";

string[] cars = new string[3] { "BMW", "Ford", "Opel" };
int[,] coords = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

Console.WriteLine("Second Car: " + cars[1]);
Console.WriteLine("X1,Y1: " + coords[0, 0]);
Console.WriteLine("X2,Y3: " + coords[1, 2]);
Console.ReadKey();
```
```
Second Car: Ford
X1,Y1: 1
X2,Y3: 6
```

```
Cast
```
```c#
Console.Title = "Cast";

double num = 10.5;
int integer = 2;

num = num + integer;
Console.WriteLine("Implicit Cast: " + num);
num = (double) 7 / integer;
Console.WriteLine("Explicit Cast: " + num);
char letter = (char)65;
Console.WriteLine("Cast Integer: " + letter);
int unicode = (int)letter;
Console.WriteLine("Cast Letter: " + unicode);
Console.ReadKey();
```
```
Implicit Cast: 12,5
Explicit Cast: 3,5
Cast Integer: A
Cast Letter: 65
```

```
Constant
```
```c#
using Constant;

Console.Title = "Constant";

const double pi = 3.14159265358979;
var daysType = typeof(Days);
string name = Enum.GetName(daysType, 1);
bool flag = Enum.IsDefined(daysType, "Mon");

Console.WriteLine("Pi Type: " + pi.GetType());
Console.WriteLine("Circumference: " + (pi * 3));
Console.WriteLine("\nFirst Name: " + Days.Sat);
Console.WriteLine("1st Index: " + (int)Days.Sat);
Console.WriteLine("\n2nd Index: " + name);
Console.WriteLine("Contains Mon?: " + flag);
Console.ReadKey();
```
```
Pi Type: System.Double
Circumference: 9,42477796076937

First Name: Sat
1st Index: 0

2nd Index: Sun
Contains Mon?: True
```

```
Arithmetic
```
```c#
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
```
```
Addition:        12
Substraction:    4
Multiplication:  32
Division:        2
Modulus:         0

Postfix Increment:       8

Postfix Result.....      9

Prefix Increment:        5

Prefix Result.....       5
```

```
Assign
```
```c#
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
```
```
Assign Values:   a = 8   b = 4


Add and Assign:          a += b (8 += 4)         a = 12

Subtract and Assign:     a -= b (12 -= 4)        a = 8

Multiply and Assign:     a *= b (8 *= 4)         a = 32

Dvivide and Assign:      a /= b (32 /= 4)        a = 8

Modulus and Assign:      a %= b (8 %= 4)         a = 0
```

```
Comparison
```
```c#
Console.Title = "Comparison";

int nil = 0, num = 0, max = 1;
char cap = 'A', low = 'a';

Console.Write("Equality: ");
Console.Write("\t (0 == 0) : " + (nil == num));
Console.Write("\n\t\t (A == a) : " + (cap == low));

Console.Write("\n\nInequality: ");
Console.Write("\t (0 != 1) : " + (nil == num));

Console.Write("\n\nGreater: ");
Console.Write("\t (0 > 1) : " + (nil > max));

Console.Write("\n\nLess: ");
Console.Write("\t\t (0 < 1) : " + (nil < max));

Console.Write("\n\nGreater/Equal: ");
Console.Write("\t (0 >= 0) : " + (nil >= num));

Console.Write("\n\nLess or Equal: ");
Console.Write("\t (1 <= 0) : " + (max <= nil));
```
```
Equality:        (0 == 0) : True
                 (A == a) : False

Inequality:      (0 != 1) : True

Greater:         (0 > 1) : False

Less:            (0 < 1) : True

Greater/Equal:   (0 >= 0) : True

Less or Equal:   (1 <= 0) : False
```

```
Logic
```
```c#
Console.Title = "Logic";

bool yes = true, no = false;

Console.Write("AND Logic:");
Console.Write("\t(yes && yes):" + (yes && yes));
Console.Write("\n\t\t(yes && no):" + (yes && no));
Console.Write("\n\t\t(no && no):" + (no && no));

Console.Write("\n\nOR Logic:");
Console.Write("\t(yes || yes):" + (yes || yes));
Console.Write("\n\t\t(yes || no):" + (yes || no));
Console.Write("\n\t\t(no  || no):" + (no || no));

Console.Write("\n\nNOT Logic:");
Console.Write("\t yes = " + yes);
Console.Write("\t !yes = " + !yes);
Console.Write("\n\t\t no = " + no);
Console.Write("\t !no = " + !no);
```
```
AND Logic:      (yes && yes):True
                (yes && no):False
                (no && no):False

OR Logic:       (yes || yes):True
                (yes || no):True
                (no  || no):False

NOT Logic:       yes = True      !yes = False
                 no = False      !no = True
```

```
Condition
```
```c#
Console.Title = "Condition";

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
```
```
There are 8

8 is  Even 
3 is  Odd 

Maximum is 8
```

```
Precedence
```
```c#
Console.Title = "Precedence";

int sum;

sum = 1 + 4 * 3;
Console.WriteLine("Default Order:\t\t" + sum);

sum = (1 + 4) * 3;
Console.WriteLine("Forced Order:\t\t" + sum);

sum = 7 - 4 + 2;
Console.WriteLine("\nDefault Direction:\t" + sum);

sum = 7 - (4 + 2);
Console.WriteLine("Forced Direction:\t" + sum);
Console.ReadKey();
```
```
Default Order:          13
Forced Order:           15

Default Direction:      5
Forced Direction:       1
```

```
IfElse
```
```c#
Console.Title = "IfElse";

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
```
```
Please Enter A Number: 1
Thanks. Now Enter A Letter: C

Number Is 5 Or Less
Letter Is 'C'
```

```
Switch
```
```c#
Console.Title = "Switch";

int num = 3;
string day;

switch (num)
{
    case 1: day = "Monday"; break;
    case 2: day = "Tuesday"; break;
    case 3: day = "Wednesday"; break;
    case 4: day = "Thursday"; break;
    case 5: day = "Friday"; break;
    default: day = "Weekend Day"; break;
}

Console.WriteLine("Day " + num + " : " + day);
Console.ReadKey();
```
```
Day 3 : Wednesday
```

```
ForLoop
```
```c#
Console.Title = "ForLoop";

for (int i = 1; i < 4; i++)
{
    Console.WriteLine("Loop Iteration: " + i);
    for (int j = 1; j < 4; j++)
    {
        Console.WriteLine("\tInner Loop Iteration: " + j);
    }
}
Console.ReadKey();
```
```
Loop Iteration: 1
        Inner Loop Iteration: 1
        Inner Loop Iteration: 2
        Inner Loop Iteration: 3
Loop Iteration: 2
        Inner Loop Iteration: 1
        Inner Loop Iteration: 2
        Inner Loop Iteration: 3
Loop Iteration: 3
        Inner Loop Iteration: 1
        Inner Loop Iteration: 2
        Inner Loop Iteration: 3
```

```
WhileLoop
```
```c#
Console.Title = "WhileLoop";

int[] nums = new int[10];
int i = 0;

while (i < nums.Length)
{
    nums[i] = i;
    Console.Write(" | " + nums[i]);
    i++;
}
Console.Write("\n\n");

do
{
    i--;
    if( i==8) { Console.Write(" | Skipped"); continue; }
    if( i==3) { Console.Write(" | Done"); break; }
    Console.Write(" | " + nums[i]);
}
while (i > 0);
Console.ReadKey();
```
```
 | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9

 | 9 | Skipped | 7 | 6 | 5 | 4 | Done
```

```
ForEach
```
```c#
Console.Title = "ForEach";

string[] websites = new string[4]
{"Google", "YouTube", "Baidu", "Yahoo!"};

Console.WriteLine("Popular Websites...");

int rank = 1;
foreach (string site in websites)
{
    Console.WriteLine("Position: " + rank + "\t" + site);
    rank++;
}
Console.ReadKey();
```
```
Popular Websites...
Position: 1     Google
Position: 2     YouTube
Position: 3     Baidu
Position: 4     Yahoo!
```

```
KeyValue
```
```c#
Console.Title = "KeyValue";

Dictionary<string, string> BookList = new Dictionary<string, string>();
BookList.Add("Michael Price", "Microsoft 365");
BookList.Add("Nick Vandome", "Windows 11");
BookList.Add("Mike McGrath", "Java");

Console.WriteLine("Popular Titles...");
foreach (KeyValuePair<string, string> book in BookList)
{
    Console.WriteLine("Key: " + book.Key + "\tValue: " + book.Value + " in easy steps");
}
Console.ReadKey();
```
```
Popular Titles...
Key: Michael Price      Value: Microsoft 365 in easy steps
Key: Nick Vandome       Value: Windows 11 in easy steps
Key: Mike McGrath       Value: Java in easy steps
```

```
Function
```
```c#
Console.Title = "Function";

static void bodyTempC()
{
    Console.WriteLine("Body Temperature...");
    Console.WriteLine("Centigrade:\t 37°C");
}

static double bodyTempF()

{
    double temperature = 98.6;
    return temperature;
}

static int bodyTempK()

{
    int temperature = 310;
    return temperature;
}

bodyTempC();
Console.WriteLine($"Fahrenheit:\t {bodyTempF()}°F");
Console.WriteLine($"Kelvin:\t\t {bodyTempK()}K");
Console.ReadKey();
```
```
Body Temperature...
Centigrade:      37°C
Fahrenheit:      98,6°F
Kelvin:          310K
```

```
Parameter
```
```c#
Console.Title = "Parameter";

double weight;
string num;

static string getWeight(out double theWeight)
{
    theWeight = 10;
    return "Ten";
}

static double lbToKg(double pounds = 5)
{
    return (pounds * 0.45359237);
}

static void kgToLb(ref double weight)

{
    weight = (weight / 0.45359237);
}

num = getWeight(out weight);
Console.WriteLine(num + " lb = " + lbToKg(weight) + " kg");
kgToLb(ref weight);
Console.WriteLine(num + " kg = " + weight + " lb");
Console.ReadKey();
```
```
Ten lb = 4,535923700000001 kg
Ten kg = 22,046226218487757 lb
```

```
Overload
```
```c#
Console.Title = "Overload";

double num;
double area;
Compute size = new();

Console.Write("Please Enter Dimension In Feet: ");
num = Convert.ToDouble(Console.ReadLine());

area = size.Zone(num);
Console.WriteLine("\nCircle:\t\tArea = " + area + " sq.ft.");

area = size.Zone(num, num);
Console.WriteLine("Square:\t\tArea = " + area + " sq.ft.");

area = size.Zone(num, num, 'T');
Console.WriteLine("Triangle:\tArea = " + area + " sq.ft.");
Console.ReadKey();

class Compute
{
    public double Zone(double width)
    {
        double radius = width / 2;
        return ((radius * radius) * 3.141593);
    }
    public double Zone(double width, double height)
    {
        return (width * height);
    }
    public double Zone(double width, double height, char letter)
    {
        return ((width / 2) * height);
    }
}
```
```
Please Enter Dimension In Feet: 23

Circle:         Area = 415,47567425 sq.ft.
Square:         Area = 529 sq.ft.
Triangle:       Area = 264,5 sq.ft.
```








