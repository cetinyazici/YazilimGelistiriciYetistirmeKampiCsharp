public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Arrays Tek Boyutlu");
        Console.WriteLine("****************");

        string[] studentds = new string[3];
        string[] teachers = { "Gaye", "Ali", "Suzan", "Yasemin", "Zehra", "Ayşe" };

        studentds[0] = "Ahmet";
        studentds[1] = "Mehmet";
        studentds[2] = "Çetin";

        foreach (var student in studentds)
        {
            Console.WriteLine(student);
        }
        Console.WriteLine("-----------");
        foreach (var teacher in teachers)
        {
            Console.WriteLine(teacher);
        }
        Console.WriteLine("-----------");
        Console.WriteLine("Arrays Çok Boyutlu");
        Console.WriteLine("****************");

        string[,] regions = new string[5, 3]
        {
            {"İstanbul","İzmit","Balıkesir"},
            {"Ankara","Konya","Kırıkkale"},
            {"Antalya","Adana","Mersin" },
            {"Rize","Trabzon","Samsun"},
            {"İzmir","Muğla","Manisa"},
        };

        for (int i = 0; i <= regions.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= regions.GetUpperBound(1); j++)
            {
                Console.WriteLine(regions[i, j]);
            }
            Console.WriteLine("----------");
        }




    }
}