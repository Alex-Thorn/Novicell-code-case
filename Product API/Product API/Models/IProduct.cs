namespace Product_API.Models;

public interface IProduct
{
    public string Id { get; set; }
    public string Title { get; set; }
    public float Price { get; set; }
    public string Category { get; set; }
}

public class Product : IProduct
{
    public Product(string id, string title, float price, string category)
    {
        Id = id;
        Title = title;
        Price = price;
        Category = category;
    }

    public string Id { get; set; }
    public string Title { get; set; }
    public float Price { get; set; }
    public string Category { get; set; }
}