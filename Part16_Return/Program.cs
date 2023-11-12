Console.Write("Please Enter Your Age : ");
var str = Console.ReadLine();
byte age = 0;

if (str == string.Empty)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Return : You Should Enter Your Age !!");
    return; // بیخیال بقیه کد ها شو - نیازی به دستور اِلس نمیباشد
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


