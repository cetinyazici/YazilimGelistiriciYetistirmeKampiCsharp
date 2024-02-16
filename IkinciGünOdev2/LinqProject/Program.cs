public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Language Integrated Query");
        Console.WriteLine("-------------------------");

        List<Category> categories = new List<Category>
        {
            new Category { CategoryId = 1, CategoryName = "Bilgisayar" },
            new Category { CategoryId = 2, CategoryName = "Telefon" },
        };

        List<Product> products = new List<Product>
        {
            new Product{ProductId=1,CategoryId=1,ProductName="Acer Laptop",QuantityPerunit="32 GB RAM",UnitPrice=10000,UnitInStock=5 },
            new Product{ProductId=2,CategoryId=1,ProductName="Asus Laptop",QuantityPerunit="16 GB RAM",UnitPrice=8000,UnitInStock=3 },
            new Product{ProductId=3,CategoryId=1,ProductName="Hp Laptop",QuantityPerunit="64 GB RAM",UnitPrice=6000,UnitInStock=2 },
            new Product{ProductId=4,CategoryId=2,ProductName="Samsung Telefon",QuantityPerunit="4 GB RAM",UnitPrice=5000,UnitInStock=15 },
            new Product{ProductId=5,CategoryId=2,ProductName="Apple Telefon",QuantityPerunit="4 GB RAM",UnitPrice=8000,UnitInStock=0 },
        };

        Console.WriteLine("-------------Algoritmik--------------");
        foreach (var product in products)
        {
            if (product.UnitPrice > 5000 && product.UnitInStock > 3)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        Console.WriteLine("----------------linq-----------------");

        var result = products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3);

        foreach (var product in result)
        {
            Console.WriteLine(product.ProductName);
        }

        GetProducts(products);
        GetProductsLinq(products);

    }

    static List<Product> GetProducts(List<Product> products)
    {
        List<Product> filteredProducts = new List<Product>();
        foreach (var product in products)
        {
            if (product.UnitPrice > 5000 && product.UnitInStock > 3)
            {
                filteredProducts.Add(product);
            }
        }
        return filteredProducts;
    }

    static List<Product> GetProductsLinq(List<Product> products)
    {
        return products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3).ToList();
    }
}

class Product
{
    public int ProductId { get; set; } //Ürün ID
    public int CategoryId { get; set; } //Kategori ID
    public string ProductName { get; set; } //Ürün İsmi
    public string QuantityPerunit { get; set; } //Ürün Açıklaması
    public decimal UnitPrice { get; set; } //Ürün Fiyat
    public int UnitInStock { get; set; } //Ürün Stok Adedi
}

class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}