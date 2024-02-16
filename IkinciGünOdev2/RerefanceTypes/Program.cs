internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("ReferanceTypes");

        //int, decima, float, enum, bool sayısal olan değişkenler değer tiptir -> ValueTypes
        int number1 = 10;
        int number2 = 20;

        number1 = number2;
        number2 = 100;
        Console.WriteLine("Number1: " + number1);
        Console.WriteLine("Number2: " + number2);

        //Arrays, Class, Interface... -> ReferanceTypes
        int[] numbers = { 1, 2, 3 };
        int[] numbers2 = { 10, 20, 30 };

        numbers = numbers2;
        numbers2[0] = 1000;

        Console.WriteLine("numbers[0]: " + numbers[0]);


        Person person1 = new Person();
        Person person2 = new Person();
        person1.FirstName = "Çetin";

        person2 = person1;
        person1.FirstName = "Ahmet";

        Console.WriteLine(person2.FirstName);

        Customer customer = new Customer();
        customer.FirstName = "Salih";
        customer.CreditCardNumber = "123456";

        Employee employee = new Employee();
        employee.FirstName = "Veli";

        Person person3 = customer;
        customer.FirstName = "Ahmet";

        Console.WriteLine(((Customer)person3).CreditCardNumber);

        PersonManager personManager = new PersonManager();
        personManager.Add(employee);
    }
}

//base class -> Person temel class
class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer : Person
{
    public string CreditCardNumber { get; set; }
}

class Employee : Person
{
    public int EmployeeNumber { get; set; }
}

class PersonManager
{
    public void Add(Person person)
    {
        Console.WriteLine(person.FirstName);
    }
}