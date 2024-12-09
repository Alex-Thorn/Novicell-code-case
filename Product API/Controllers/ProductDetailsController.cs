using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Product_API.Models;

namespace Product_API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductDetailsController : ControllerBase
{
    [HttpGet("/GetProductDetails/{id}")]
    public IResult Get(string id)
    {
        IList<ProductDetails>? productDetailsList;

        using (StreamReader r = new StreamReader("../products-sample-v1.json")) //normally you fetch this from a database
        {
            string json = r.ReadToEnd();  
            productDetailsList = JsonSerializer.Deserialize<List<ProductDetails>>(json);  
        }

        ProductDetails? productdetails = null;
        if (productDetailsList != null)
        {
            productdetails = productDetailsList.FirstOrDefault(d => d.Id == id);
        }

        return productdetails != null ? Results.Ok(productdetails) : Results.NotFound("The product with this Id does not exist");
    }
}