
// +,-,*,/,%
// Operator عملگر
// Operand عملوند
// a+b

var randomObj = new Random();
var a = randomObj.Next();
var b = randomObj.Next();

int sum = a + b;
int mul = a * b;
int sub = a - b;
int div = a / b;
int rem = a % b;

Console.WriteLine($"{a} + {b} = {sum}");
Console.WriteLine($"{a} - {b} = {sub}");
Console.WriteLine($"{a} * {b} = {mul}");
Console.WriteLine($"{a} / {b} = {div}");
Console.WriteLine($"{a} % {b} = {rem}");

Console.ForegroundColor = ConsoleColor.Green;


ulong sum2 = (ulong)a + (ulong)b;
ulong mul2 = (ulong)(a * b);
ulong mul3 = (ulong)a * (ulong)b;

int sub2 = a - b;
float div2 = (float)a / b;
double div3 = (double)a / b;
float rem2 = (float)a % (float)b;

Console.WriteLine($"{a} + {b} = {sum2}");
Console.WriteLine($"{a} - {b} = {sub2}");
Console.WriteLine($"{a} * {b} = {mul2}");
Console.WriteLine($"{a} * {b} = {mul3}");

Console.WriteLine($"{a} / {b} = {div2}");
Console.WriteLine($"{a} / {b} = {div3}");
Console.WriteLine($"{a} % {b} = {rem2}");


Console.ForegroundColor = ConsoleColor.Magenta;

a = randomObj.Next(1,6);
b = randomObj.Next(1,6);

ulong sum3 = (ulong)a + (ulong)b;
ulong mul4 = (ulong)(a * b);
ulong mul5 = (ulong)a * (ulong)b;

int sub3 = a - b;
float div4 = (float)a / b;
double div5 = (double)a / b;
float rem3 = (float)a % (float)b;

Console.WriteLine($"{a} + {b} = {sum3}");
Console.WriteLine($"{a} - {b} = {sub3}");
Console.WriteLine($"{a} * {b} = {mul4}");
Console.WriteLine($"{a} * {b} = {mul5}");

Console.WriteLine($"{a} / {b} = {div4}");
Console.WriteLine($"{a} / {b} = {div5}");
Console.WriteLine($"{a} % {b} = {rem3}");

Console.ForegroundColor = ConsoleColor.Green;

a = 10;
b = 3;

Console.WriteLine($"{a+b}");
Console.WriteLine($"{(a + b)*2}");
Console.WriteLine($"{a + b * 2}");
Console.WriteLine($"{a * 2 + b}");
Console.WriteLine($"{a * (2 + b)}");