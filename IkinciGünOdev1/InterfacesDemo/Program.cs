internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("INTERFACE DEMO");

        IWorker[] workers = new IWorker[3]
        {
            new Worker(),
            new Manager(),
            new Robot(),
        };

        foreach (var worker in workers)
        {
            worker.Work();
        }

        IEat[] eats = new IEat[2]
        {
            new Worker(),
            new Manager(),
        };

    }

    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void Salary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Ate!!");
        }

        public void Salary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Ate!!");
        }

        public void Salary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("");
        }
    }

}