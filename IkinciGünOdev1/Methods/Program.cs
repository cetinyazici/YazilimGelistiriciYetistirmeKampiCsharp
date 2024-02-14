public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Methods");
        Console.WriteLine("----------------");
        int result1 = Add(10, 20);
        Console.WriteLine("Total: " + result1);
        AddMessage();
        int result2 = Add(20);
        Console.WriteLine("Total: " + result2);
        AddMessage();
        Console.WriteLine("----------------");

        int num1 = 10;
        int num2 = 20;

        //ref: değeri olmak zorunda yani set edilmek zorunda ve  methoda girdikten sonra değer değişir.
        //out: değeri olmak zorunda değil ama gönderildiği methot içerisnde set edilmek zorunda.

        int result = Add2(ref num1, num2);
        Console.WriteLine("Total: " + result);
        Console.WriteLine("Num1: " + num1);
        Console.WriteLine("----------------");

        Console.WriteLine(Multiply(2, 5));
        Console.WriteLine(Multiply(2, 5, 4));
        Console.WriteLine("----------------");

        Console.WriteLine(Add3(12,45,5,5,5));

    }

        static void AddMessage()
        {
            Console.WriteLine("Added!");
        }

        //Default değer verildiği zaman eğer girilmezse verilen değeri alır.
        static int Add(int number1, int number2 = 0)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add2(ref int num1, int num2)
        {
            num1 = 30;
            return num1 + num2;
        }

        //Overloading: Aynı method isminde farklı parametre alma işlemine denir.
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        //params: fazla sayı gelme olasılığı ile işlem yapabilme özelliği sağlar.
        static int Add3(params int[] numbers)
        {
            return numbers.Sum();
        }
}