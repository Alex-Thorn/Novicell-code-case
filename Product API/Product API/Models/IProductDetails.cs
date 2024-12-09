namespace Product_API.Models;

public interface IProductDetails
{
    public string Id { get; set; }
    public string Title { get; set; }
    public float Price { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public string Image { get; set; }
}

public class ProductDetails : IProductDetails
{
    public ProductDetails(string id, string title, float price, string description, string category, string image)
    {
        Id = id;
        Title = title;
        Price = price;
        Description = description;
        Category = category;
        Image = image;
    }

    public string Id { get; set; }
    public string Title { get; set; }
    public float Price { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public string Image { get; set; }
}