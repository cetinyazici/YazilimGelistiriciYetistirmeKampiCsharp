internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("String");
        Console.WriteLine("-------");
        //Intro();

        string sentence = "My name is Çetin";

        
        var result = sentence.Length;           //karakter sayısını verir.
        var result2 = sentence.Clone();         //Bir referansını oluşturur. klonlama
        sentence = "My name is Muhammet";
        bool result3 = sentence.EndsWith("Çetin");  //Bu cümle n karakteri ile bitiyor mu?
        bool result4 = sentence.StartsWith("My name");  //Bu cümle ---  ile başlıyor mu?
        var result5 = sentence.IndexOf("name");     //Belli bir ifadeyi bulmak için kullanılır. Bulamazsa -1 verir.
        var result6 = sentence.IndexOf(" ");    //Bulduğu ilk kısmı bize verir.
        var result7 = sentence.LastIndexOf(" ");    //Aramaya sondan başlar.
        var result8 = sentence.Insert(0,"Hello, ");    //söylenilen indexe ekleme yapar. 
        var result9 = sentence.Substring(3,4);    //Metni parçalamak için kullanılır. 3. karakterden al demek.İkinci kısım uzunluğu temsil eder.
        var result10=sentence.ToLower(); //küçüğe çevir 
        var result11=sentence.ToUpper(); //büyüğe çevir
        var result12 = sentence.Replace(" ","-"); // değişmek için boşlık olanlar çizgi olsun mesela 
        var result13 = sentence.Remove(2,5); // silmek için 2den itibaren silinsin 

        Console.WriteLine(result);
        Console.WriteLine(result2);
        Console.WriteLine(result3);
        Console.WriteLine(result4);
        Console.WriteLine(result5);
        Console.WriteLine(result6);
        Console.WriteLine(result7);
        Console.WriteLine(result8);
        Console.WriteLine(result9);
        Console.WriteLine(result10);
        Console.WriteLine(result11);
        Console.WriteLine(result12);
        Console.WriteLine(result13);



    }

    private static void Intro()
    {
        string city = "Erzurum";
        string city2 = "İstanbul";

        Console.WriteLine(city);
        Console.WriteLine(city[0]);

        foreach (var item in city)
        {
            Console.WriteLine(item);
        }

        //stringler yan yana gelir.
        string result = city + city2;
        Console.WriteLine(result);

        //Alternatif olarak:      boşluk iki yazı arasına koyar 
        Console.WriteLine(String.Format("{0} {1}", city, city2));
    }
}