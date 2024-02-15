public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Loops");
        Console.WriteLine("-----------");

        int number = 7;
        int number2 = 4;

        //     başlangıç     şart       artış
        for (int i = 0; i <= number; i = i + 2)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("----------");

        while (number >= 0)
        {
            Console.WriteLine(number);
            number--;
        }

        Console.WriteLine("----------");

        //önce döngüye girer sonra şarta ilk etapta şart sağlanmasa bile yazdırma işlemi gerçekleşir.
        do
        {
            Console.WriteLine(number2);
            number2--;

        } while (number2 >= 0);

        Console.WriteLine("----------");

        string[] students = { "Ahmet", "Çetin", "Ayşe", "Hasan" };

        foreach (var student in students)
        {
            Console.WriteLine(student);
        }

        if (IsPrimeNumber(7))
        {
            Console.WriteLine("This is a prime number.");
        }
        else
        {
            Console.WriteLine("This is not a prime number");
        }
    }

    private static bool IsPrimeNumber(int number)
    {
        bool result = true;

        for (int i = 2; i < number-1; i++)
        {
            if(number%i==0)
            {
                result= false;
                i = number;
            }
        }
        return result;
    }
}