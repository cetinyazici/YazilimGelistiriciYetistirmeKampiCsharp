//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//string message = "Merhaba";
//Console.WriteLine(message);

//double amount = 10000;
//Console.WriteLine(amount);

//int number  = 50;
//Console.WriteLine(number);

//bool isAuthenticated  = false;
//Console.WriteLine(isAuthenticated);

//string name = "Çetin";
//string surname = "Yazıcı";
//int birth = 2000;
//long tcNumber = 10210210210;

//Vatandas vatandas1 = new Vatandas();


using Business.Concrete;
using Entities.Concrete;

SelamVer("Çetin");
SelamVer(name:"Ahmet");
SelamVer();

Topla(5,6);

Console.WriteLine("---------------------");
//Diziler (Arrays)

string[] students = new string[4];
students[0] = "çetin";
students[1] = "ahmet";
students[2] = "ali";
students[3] = "hüseyin";

for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine(students[i]);
}
Console.WriteLine("------------------");
foreach (string item in students)
{
    Console.WriteLine(item);
}
Console.WriteLine("------------------");

List<string> list = new List<string> {"ali","ahmet", "akın", "arzu" };
list.Add("ayşe");

foreach (var item in list)
{
    Console.WriteLine(item);
}
Console.WriteLine("------------------");

Person person1 = new Person();
person1.firsName = "ÇETİN";
person1.lastName = "YAZICI";
person1.dateOfBirthYear = 2000;
person1.nationalIdentity = 123456;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

static void SelamVer(string name = "noName")
{
    Console.WriteLine("Merhaba " + name);
}

static int Topla(int number1, int number2)
{
    int sonuc = number1 + number2;
    Console.WriteLine("Toplam: "+sonuc);
    return sonuc;
}

public class Vatandas
{
    public string name { get; set; }
    public string surname { get; set; }
    public int birthYear { get; set; }
    public long tcNumber { get; set; }
}