namespace MinimalAPISample;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetProducts()
    {
        return Ok(new[] { "Product 1", "Product 2", "Product 3", "Product 4" });
    }
    
    [HttpGet("{id}")]
    public IActionResult GetProduct(int id)
    {
        return Ok($"Product {id}");
    }
    
    [HttpPost]
    public IActionResult AddProduct([FromBody] string product)
    {
        return Ok($"Product {product} added");
    }
    
    [HttpPut("{id}")]
    public IActionResult UpdateProduct(int id, [FromBody] string product)
    {
        return Ok($"Product {id} updated to {product}");
    }
    
    [HttpDelete("{id}")]
    public IActionResult DeleteProduct(int id)
    {
        return Ok($"Product {id} deleted");
    }
}