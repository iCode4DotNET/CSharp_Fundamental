#region [ Tell Story ]

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Welcome Dear User....");
Console.WriteLine("You should enter your information..............");
Console.WriteLine($"Today is {DateTime.Now.ToLongDateString()} !");
Console.WriteLine("Please Enter a Key When you are Ready to Go .... :-)");
Console.ReadKey();
Console.Clear();
Console.ResetColor();
#endregion

Console.Write("Please Enter Your Age : ");
var str = Console.ReadLine();
byte age = 0;

if (str == string.Empty)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("You Should Enter Your Age !!");
}

if (str != null)
    age = byte.Parse(str);

if (age == 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Your Age is Invalid !!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Your Age is {age}");
}
