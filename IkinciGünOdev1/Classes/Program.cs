using Classes;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("CLASSES");

        Customer customer = new Customer();
        customer.Id = 1;
        customer.FirstName = "Çetin";
        customer.LastName = "Yazıcı";
        customer.Address = "Erzurum-Aziziye";

        Customer customer2 = new Customer();
        customer2.Id = 2;
        customer2.FirstName = "Ahmet";
        customer2.LastName = "Kaya";
        customer2.Address = "Ankara-Çankaya";

        Customer customer3 = new Customer 
        {
            Id = 3,
            FirstName="Ali",
            LastName="Arsız",
            Address="Antep"
        };

        Console.WriteLine(customer.FirstName);
        Console.WriteLine(customer2.FirstName);
        Console.WriteLine(customer3.FirstName);

        Console.WriteLine();

        CustomerManager customerManager = new CustomerManager();
        customerManager.Add();
        customerManager.Update();

        Console.WriteLine();

        ProductManager productManager = new ProductManager();
        productManager.Add();   
        productManager.Update();
    }
}