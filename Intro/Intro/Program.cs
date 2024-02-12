// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.DataAccess.Concretes;
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

CourseManager courseManager = new(new DapperCourseDal()); //yeni syntax new CourseManager(); demek aslında 
List<Course> courses2 = courseManager.GetAll();

for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses2[i].Name);
    Console.WriteLine(courses2[i].Description);
    Console.WriteLine(courses2[i].Price);
}

Console.WriteLine("-----------------------------");
int number1 = 10;//20
int number2 = 20;

number1 = number2;
number2 = 50; //bir önemi yoktur.

Console.WriteLine(number1);
Console.WriteLine(number2);
//value types -> int, bool, double bu gruba girer.

string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
string[] cities2 = { "Bursa", "Bolu", "Diyarbakır" };

cities2 = cities1; //şehirler2 nini referans numarası şehirler1 e atanıyor aslında okunuşu bu şekilde
cities1[0] = "Adana";

Console.WriteLine(cities2[0]);
Console.WriteLine(cities1[1]);
//reference types -> string, Array, class, interface bu gruba girer.

Console.WriteLine("-----------------------------");
Console.WriteLine("Kod bitti....");
Console.WriteLine("-----------------------------");


IndividualCustomer customer1    = new IndividualCustomer();
customer1.Id = 1;
customer1.CustomerNumber = "123456";
customer1.NationalIndentity = "12345678911";
customer1.FirstName = "Çetin";
customer1.LastName = "Yazıcı";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.CustomerNumber = "123457"; 
customer2.NationalIndentity = "98765432123"; 
customer2.FirstName = "Hüseyin"; 
customer2.LastName = "Kurt"; 

CoorporateCustomer customer3 = new CoorporateCustomer();
customer3.Id = 3;
customer3.Name = "kodlamaio";
customer3.CustomerNumber = "96385";
customer3.TaxNumber = "12345678987";

CoorporateCustomer customer4 = new CoorporateCustomer();
customer4.Id = 4;
customer4.Name = "koddankazan";
customer4.CustomerNumber = "96389";
customer4.TaxNumber = "12345678988";

BaseCustomer[] customers = {customer1, customer2, customer3, customer4};

//polymorphism->poliformizim
foreach (BaseCustomer item in customers)
{
    Console.WriteLine(item.CustomerNumber);
}