namespace Product_API.Models;

public interface IProductCategory
{
    public string Id { get; set;  }
    public string Name { get; set; }
    public string Description { get; set; }
}

public class ProductCategory : IProductCategory
{
    public ProductCategory(string id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }

    public string Id { get; set;  }
    public string Name { get; set; }
    public string Description { get; set; }
}