int number1 = 100;
string str = "";

//Cannot implicitly convert type 'int' to 'string'	
//str = number1;

str = number1.ToString();

//string str2 = "you number = " + number1.ToString();

string str2 = "you number = " + number1;

string inputNumber = "12345";

//OverflowException: 'Value was either too large or too small for an unsigned byte.'
//byte number2 = Convert.ToByte(inputNumber);

short number3 = Convert.ToInt16(inputNumber);
int number4 = Convert.ToInt32(inputNumber);
long number5 = Convert.ToInt64(inputNumber);
ulong number6 = Convert.ToUInt64(inputNumber);

//number2 = inputNumber;

//OverflowException: 'Value was either too large or too small for an unsigned byte.'
//var number2 = byte.Parse(inputNumber);

number3 = short.Parse(inputNumber);
number4 = int.Parse(inputNumber);
number5 = long.Parse(inputNumber);
number6 = ulong.Parse(inputNumber);

//FormatException: 'String '12345' was not recognized as a valid DateTime.'
//var number7 = DateTime.Parse(inputNumber);