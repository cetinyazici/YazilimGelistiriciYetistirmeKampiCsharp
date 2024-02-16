internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Interfaces");
        Console.WriteLine("----------");

        //onu implemente eden classın referansını tutar.    
        IPersonManager customerManager = new Customer();
        customerManager.Add();
        customerManager.Update();

        Console.WriteLine();

        IPersonManager employeeManager=new Employee();
        employeeManager.Add();
        employeeManager.Update();
        
        Console.WriteLine();

        IPersonManager internManager = new Intern();
        internManager.Add();
        internManager.Update();

        Console.WriteLine();

        ProjectaManager projectaManager1=new ProjectaManager();
        projectaManager1.Add(customerManager);
        projectaManager1.Add(employeeManager);
        projectaManager1.Add(internManager);


    }
}

interface IPersonManager
{
    //unimplemented operation
    void Add();
    void Update();
}

//inheritans - class ------------------------implements - interface
class Customer : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Müşteri eklendi!!");
    }

    public void Update()
    {
        Console.WriteLine("Müşteri güncellendi!!");
    }
}

class Employee : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Çalışan eklendi!!");
    }

    public void Update()
    {
        Console.WriteLine("Çalışan güncellendi!!");
    }
}

class Intern : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Stajyer eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Stajyer güncellendi");
    }
}

class ProjectaManager 
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }
}