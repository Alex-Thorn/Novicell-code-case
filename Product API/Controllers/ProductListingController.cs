using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Product_API.Models;

namespace Product_API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductListingController : ControllerBase
{
    [HttpGet(Name = "GetProductListing")]
    public IResult Get(string? category)
    {
        IList<Product>? productList;

        using (StreamReader r = new StreamReader("../products-sample-v1.json")) //normally you fetch this from a database
        {
            string json = r.ReadToEnd();  
            productList = JsonSerializer.Deserialize<List<Product>>(json);  
        }

        if (category != null)
            productList = productList.Where(p => p.Category == category).ToList();

        return productList != null ? Results.Ok(productList) : Results.NotFound("This list is empty");
    }
}