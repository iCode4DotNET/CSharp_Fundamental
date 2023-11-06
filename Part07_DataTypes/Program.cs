Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Hello, World! .NET 7");

// Naming Convention !! قرارداد های نام گذاری
// Camel Case

string firstName = "Mr Soroush";
string lastName = "Sadr";

int age = 39;
double grade = 19.55;

bool isMarried = false;

DateTime birthDate = new DateTime(1984, 1, 31);

Console.WriteLine("First Name = " + firstName + " Last Name = " + lastName + " Age = " + age + " Grade = " + grade + " Is Married = " + isMarried + " Birth Date = " + birthDate);

Console.WriteLine(byte.MaxValue);
Console.WriteLine(short.MaxValue);
Console.WriteLine(int.MaxValue);
Console.WriteLine(long.MaxValue);
Console.WriteLine(ulong.MaxValue);


Console.WriteLine("First Name = {0} Last Name = {1} Age = {2} Grade = {3} Is Married = {4} Birth Date = {5}",
                   firstName,
                   lastName,
                   age,
                   grade,
                   isMarried,
                   birthDate);

string format = "First Name = {0} Last Name = {1} Age = {2} Grade = {3} Is Married = {4} Birth Date = {5}";

Console.WriteLine(format,firstName,lastName,age,grade,isMarried,birthDate);


Console.WriteLine($"First Name = {firstName} Last Name = {lastName} Age = {age} Grade = {grade} Is Married = {isMarried} Birth Date = {birthDate}");



Console.ForegroundColor = ConsoleColor.White;


