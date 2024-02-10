// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 100000;

//veriables -->camelCase
bool isAuthenticated = false; //otantikeytıd

Console.WriteLine(message1);

//condition(şart)
if (isAuthenticated)
{
    Console.WriteLine("Buton-->Hoşgeldin Çetin");
}
else
{
    Console.WriteLine("Buton-->Sisteme giriş yap.");
}

string[] loans = { "kredi1", "kredi2", "kredi3", "kredi4", "kredi5", "kredi6" };//dbden gelecek.
//string[] loans2 = new string[5];
//loans2[0] = "kredi1";

     //start      condition       increment
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

Console.WriteLine("-----------------------------");

Course course1 = new Course();
course1.Id = 1;
course1.Name = "C#";
course1.Description = ".NET 8 ...";
course1.Price = 0;

Course course2 = new Course();
course2.Id = 2;
course2.Name = "JAVA";
course2.Description = "JAVA 17 ...";
course2.Price = 10;

Course course3 = new Course();
course3.Id = 3;
course3.Name = "PYTHON";
course3.Description = "PYTHON 3.12 ...";
course3.Price = 20;

Course[] courses = { course1, course2, course3 };

for (int i = 0; i <courses.Length; i++)
{
    Console.WriteLine(courses[i].Name);
    Console.WriteLine(courses[i].Description);
    Console.WriteLine(courses[i].Price);
    Console.WriteLine("---");
}
Console.WriteLine("-----------------------------");

CourseManager courseManager = new(); //yeni syntax new CourseManager(); demek aslında 
Course[] courses2 = courseManager.GetAll();

for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses2[i].Name);
    Console.WriteLine(courses2[i].Description);
    Console.WriteLine(courses2[i].Price);
}

Console.WriteLine("-----------------------------");
Console.WriteLine("Kod bitti....");