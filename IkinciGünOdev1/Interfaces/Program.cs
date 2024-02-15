using Interfaces;
using System.ComponentModel;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("İNTERFACES");

        //InterfaceIntro();
        //Demo();

        //İnterfaceler asla newlenemezler
        //katmanlar arası geçişlerde fazlasıyla interface kullanılır bağımlılığı azaltmak için.

        ICustomerDal[] customerDals = new ICustomerDal[3]
        {
            new SqlServerCustomerDal(),
            new OracleCustomerDal(),
            new MySglCustomerDal()
        };

        foreach (var customerDal in customerDals)
        {
            customerDal.Add();
        }


    }

    private static void Demo()
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(new SqlServerCustomerDal());
        customerManager.Add(new OracleCustomerDal());
    }

    private static void InterfaceIntro()
    {
        Customer customer1 = new Customer();
        customer1.Id = 1;
        customer1.FirstName = "Çetin";
        customer1.LastName = "Yazıcı";
        customer1.Address = "Erzurum";

        Student student1 = new Student();
        student1.Id = 2;
        student1.FirstName = "Ali";
        student1.LastName = "Akın";
        student1.Departmant = "Computer Sciences";

        Morker morker1 = new Morker();

        PersonManager personManager = new PersonManager();
        personManager.Add(customer1);
        personManager.Add(student1);
        personManager.Add(morker1);
    }
}

//soyut
interface IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

}

//somut
class Customer : IPerson
{

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
}
class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}

class Morker : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}
class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine("Added Customer1 " + person.FirstName);
    }
}