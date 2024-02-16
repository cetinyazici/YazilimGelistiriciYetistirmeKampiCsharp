internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Consructors");
        //yapıcı blok

        Customer customer1 = new Customer { Id = 1, FirstName = "Çetin", LastName = "Yazıcı", City = "Erzurum" };
        Customer customer2 = new Customer(2, "Ali", "Kaya", "Sivas");

        Console.WriteLine(customer2.FirstName);
        Console.WriteLine(customer2.LastName);
        Console.WriteLine(customer1.FirstName);
        Console.WriteLine(customer1.LastName);

    }
}

class Customer
{
    public Customer()
    {

    }
    //Default Cosructor
    public Customer(int id, string firstName, string lastName, string city)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        City = city;
    }
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}