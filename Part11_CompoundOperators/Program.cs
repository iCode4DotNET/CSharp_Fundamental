var number1 = new Random(Seed: 100).Next();
var number2 = new Random(Seed: 200).Next();

// عملگرهای مقایسه ای
// جواب بله و خیر
// true , false
Console.WriteLine($"{number1 == number2}");
Console.WriteLine($"{number1 != number2}");
Console.WriteLine($"{number1 > number2}");
Console.WriteLine($"{number1 < number2}");
Console.WriteLine($"{number1 >= number2}");
Console.WriteLine($"{number1 <= number2}");

// Compound Operators

number1 = 100;
number2 = 200;

number1 = number1 + number2;
number1 += number2;

number2 += number1;
number2 -= number1;
number2 *= number1;
number2 /= number1;
number2 %= number1;

number2 = number2 + 1;
number2++;

number2 += 10;
number2 -= 10;
number2 *= 10;
number2 /= 10;
number2 %= 10;


