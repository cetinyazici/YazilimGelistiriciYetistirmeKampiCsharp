// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World");

//Value Types
int number1 = 25; //32 bit yer kaplar.
long number2 = 50; //64 bit yer kaplar. 19 karakterden oluşur
short number3 = 12; //16 bit yer kaplar.
byte number4 = 255; //8 bit yer kaplar.
bool condition = true;
char character = 'A';
double number5 = 2.5; //64 bit yer kaplar.
decimal number6 = 5.0m; //sayıdan sonra m koymamız lazım
var number7 = 45; //Değere göre tip alır.
number7 = 'A'; //ascıı karaketerine karşılık geldi.


Console.WriteLine("Number1 is " + number1);
Console.WriteLine("Number2 is " +  number2);
Console.WriteLine("Number3 is " + number3);
Console.WriteLine("Number4 is " + number4);
Console.WriteLine("Bool is " + condition);
Console.WriteLine("Char is " + character);
Console.WriteLine("Char is " + (int)character); //ASCII karakter karşılığı.
Console.WriteLine("Number5 is " + number5);
Console.WriteLine("Decimal Number6 is " + number6);
Console.WriteLine(Days.Friday);
Console.WriteLine((int)Days.Friday);
Console.Write("Var Number7 is " + number7);

enum Days
{
    //0        1           2        3        4         5       6   
    Monday=1, Tueasday, Wednestay, Thursday, Friday, Saturday, Sandey
}