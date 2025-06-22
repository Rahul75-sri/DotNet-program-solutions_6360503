using System;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }

    public Product(int id, string name, string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }
}

class Program
{
    public static Product LinearSearch(Product[] products, int targetId)
    {
        foreach (var product in products)
        {
            if (product.ProductId == targetId)
                return product;
        }
        return null;
    }

    public static Product BinarySearch(Product[] products, int targetId)
    {
        int left = 0, right = products.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (products[mid].ProductId == targetId)
                return products[mid];
            if (products[mid].ProductId < targetId)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return null;
    }

    static void Main()
    {
        Product[] products = {
            new Product(101, "Wireless Mouse", "Electronics"),
            new Product(203, "Cotton T-Shirt", "Clothing"),
            new Product(305, "Coffee Maker", "Home Appliances")
        };

        var foundLinear = LinearSearch(products, 203);
        Console.WriteLine(foundLinear != null ? $"Linear: {foundLinear.ProductName}" : "Not found (Linear)");

        Array.Sort(products, (x, y) => x.ProductId.CompareTo(y.ProductId));
        var foundBinary = BinarySearch(products, 203);
        Console.WriteLine(foundBinary != null ? $"Binary: {foundBinary.ProductName}" : "Not found (Binary)");
    }
}
