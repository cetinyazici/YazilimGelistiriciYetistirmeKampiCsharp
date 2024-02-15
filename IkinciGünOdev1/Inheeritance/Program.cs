using System.Security.Authentication;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Inheritance: kalıtım, miras alma");
        //interface birden fazla kullanılabilirken inheritance de bir classın birden fazla babası olamaz.
        //interface-> tek başına bir anlam ifade etmez
        //inheritance-> tek başına bir anlam ifade eder.

        Person[] persons = new Person[3]
        {
            new Person{FirstName="Çetin"},
            new Customer{FirstName="Ahmet"},
            new Student{FirstName="Ali"},
        };

        foreach (var person in persons)
        {
            Console.WriteLine(person.FirstName);
            
        }


        Customer customer = new Customer();
        customer.Id = 1;
        customer.FirstName = "Test";
        customer.LastName = "Test";
        customer.City = "Test";
    }


    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Departmant { get; set; }
    }
}