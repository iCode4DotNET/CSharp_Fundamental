
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Welcome 2 Session 02");

// Data Type
// Simple Data Type  : int , char , float , string , ...
// Complex Data Type : DateTime 

// Value Data Type     : struct , int , float , double ,datetime
// Reference Data Type : class , object , string

// Value     : Non-Nullable , Stack
// Reference : Nullable , Heap

//Cannot convert null to 'DateTime' because it is a non-nullable value type	
        //DateTime yourBirthDate = null;
        //int yourNumber = null;

//DateTime? yourBirthDate = null;
//int? yourNumber = null;
//Console.WriteLine(yourNumber);
//Console.WriteLine(yourBirthDate.Value.ToLongDateString());

//string yourName = null;
//object yourData = null;

//Console.WriteLine(yourData);
//Console.WriteLine(yourName);


DateTime? yourBirthDate = null;
int? yourNumber = null;
Console.WriteLine(yourNumber);
Console.WriteLine(yourBirthDate.HasValue?yourBirthDate.Value.ToLongDateString() : "N/A");

string? yourName = null;
object? yourData = null;

Console.WriteLine(yourData);
Console.WriteLine(yourName);




//var birthDate = new DateTime(2000, 1, 1);
//DateTime birthDate2 = new DateTime(2000, 1, 1);

//string firstName = "Soroush";
//string lastName = "Sadr";
//double grade = 19.99;
//float average = 19.99F;
//double grade2 = 19.99D;

//object myObject1 = true;
//object myObject2 = "Salam";
//object myObject3 = 1234.5678;

//Int32 number1 = 123;

//string note = null;
////int abc = null; //Error
//string? note3 = "";
//Console.WriteLine(note3);


//string note2;
//Console.WriteLine(note2);
