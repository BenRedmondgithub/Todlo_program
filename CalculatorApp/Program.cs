Console.WriteLine("Hello!");
Console.WriteLine("Input the first number:");
var firstAsText = Console.ReadLine();
var number1 = int.Parse(firstAsText);

Console.WriteLine("Input the second number:");
var secondAsText = Console.ReadLine();
var number2 = int.Parse(firstAsText);

Console.WriteLine("What do you want to do?");
Console.WriteLine("{A}dd a Number:");
Console.WriteLine("{S}ubtract Number:");
Console.WriteLine("{M}ultiply a Number: ");

var Choice = Console.ReadLine();

if(Choice == "A" || Choice =="a")
{
   var sum = number1 + number2;
   PrintFinalEquation(number1, number2, sum, " + ");
}

else if(Choice == "S" || Choice =="s")
{
   var different = number1 - number2;
   PrintFinalEquation(number1, number2, different, " - ");
}

else if(Choice == "M" ||  Choice =="m")
{
    var multip = number1 * number2;
    PrintFinalEquation(number1, number2, multip, " * ");
}

else
{
    Console.WriteLine("Invalid Choice!");
}

void PrintFinalEquation(int number1, int number2, int result, string @operator) 
{
    Console.WriteLine(number1 + "" + @operator + "" + number2 + " = " + result);
}

Console.WriteLine("Press any key to close");

Console.ReadKey();
