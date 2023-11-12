#region [ Tell Story ]

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Welcome Dear User....");
Console.WriteLine("You should enter your information..............");
Console.WriteLine($"Today is {DateTime.Now.ToLongDateString()} !");
Console.WriteLine("Please Enter a Key When you are Ready to Go .... :-)");
Console.ReadKey();
Console.Clear();

#endregion

#region [ Get Data ]

Console.Write("Please Enter Your First Name : ");
var firstName = Console.ReadLine();

Console.Write("Please Enter Your Last Name : ");
var lastName = Console.ReadLine();

Console.Write("Please Enter Your Birth Date (2000/01/01) : ");
var birthDate = Convert.ToDateTime(Console.ReadLine());

Console.Write("Please Enter Your Grade : ");
var grade = Convert.ToSingle(Console.ReadLine());

Console.ReadKey();
Console.Clear();
#endregion

#region [ Calculation / Processing / Business]

var fullName = firstName + " " + lastName;
var age = DateTime.Now.Year - birthDate.Year;
var birthDateInfo = birthDate.ToLongDateString();
#endregion

#region [ Show Result / Output ]

Console.WriteLine("-------------------------");
Console.WriteLine($"your Name is {fullName} " +
                  $"Your Age is {age} " +
                  $"Your Birthdate is {birthDateInfo}"); 
#endregion