// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var number1 = 10;
int number2 = 10;

Console.WriteLine("Number1: " + number1);
Console.WriteLine("Number2: " + number2);
Console.WriteLine("------------------");

if (number1 == 11)
{
    Console.WriteLine("Number is 10");
}
else if (number1 == 20)
{
    Console.WriteLine("Number is 20");
}
else
{
    Console.WriteLine("Number is not 10 or 20");
}
//                  şart kısmı          true            false
Console.WriteLine(number1 == 10 ? "Number is 10" : "Number is not 10");
Console.WriteLine("------------------");

switch (number2)
{
    case 10:
        Console.WriteLine("Number is 10");
        break;
    case 20:
        Console.WriteLine("Number is 20");
        break;
    default:
        Console.WriteLine("Number is not 10 or 20");
        break;
}
Console.WriteLine("------------------");

int number3 = 500;
if (number3>=0 && number3<=100)
{
    Console.WriteLine("Number is between 0-100");
}
else if (number3>100 && number3<=200)
{
    Console.WriteLine("Number is between 100-200");
}
else if(number3<0 || number3>200)
{
    Console.WriteLine("Number is less than 0 or greater than 200");
}
Console.WriteLine("------------------");


