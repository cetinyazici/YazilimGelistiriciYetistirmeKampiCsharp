internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Generics");

        List<string> citys = new List<string>();
        citys.Add("Ankara");
        citys.Add("Ankara");
        citys.Add("Ankara");
        citys.Add("Ankara");
        citys.Add("Ankara");
        Console.WriteLine(citys.Count);

        MyList<string> students = new MyList<string>();
        students.Add("Erzurum");
        students.Add("Erzurum");
        students.Add("Erzurum");
        students.Add("Erzurum");
        students.Add("Erzurum");
        Console.WriteLine(students.Count);

    }
}

class MyList<T>  //Generic class
{
    T[] _array;
    T[] _tempArray; //geçici array öncekileri kaybetmemek için kullanırız.
    public MyList()
    {
        _array = new T[0];
    }
    public void Add(T item)
    {
        _tempArray = _array;
        _array = new T[_array.Length + 1];
        for (int i = 0; i < _tempArray.Length; i++)
        {
            _array[i] = _tempArray[i];
        }
        _array[_array.Length-1]= item;
    }

    public int Count
    {
        get { return _array.Length; }
    }

}