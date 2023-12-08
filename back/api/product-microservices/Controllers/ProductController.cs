using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private ProductDbContext _products;
    public ProductController(ProductDbContext products)
    {
        _products = products;
    }

    // GET api/<ProductController>
    [HttpGet]
    public IActionResult Get()
    {
        var product = _products.Products;
        return Ok(product);
    }

    public Product GetById(string id)
    {
        var products = _products.Products.Find(id);
        if (products == null) { throw new KeyNotFoundException("Product not found"); }
        return products;
    }

    // GET api/<ProductController>/5
    [AllowAnonymous]
    [HttpGet("{id}")]
    public IActionResult Get(string id)
    {
        var emp = _products.Products.Find(id);
        return Ok(emp);
    }

    // POST api/<ProductController>
    [HttpPost]
    public IActionResult Post([FromBody] Product model)
    {
        string guid = Guid.NewGuid().ToString();
        while (_products.Products.Any(e => e.ID == guid))
        {
            guid = Guid.NewGuid().ToString();
        }
        model.ID = guid;

        _products.Add(model);
        _products.SaveChanges();

        return Ok(new { Message = "Product created" });
    }

    // PUT api/<ProductController>/5
    [HttpPut("{id}")]
    public IActionResult Put([FromBody] Product model)
    {
        _products.Products.Attach(model);
        _products.Entry(model).State = EntityState.Modified;

        _products.SaveChanges();

        return Ok(new { Message = "Product updated" });
    }

    // DELETE api/<ProductController>/5
    [HttpDelete("{id}")]
    public IActionResult Delete(string id)
    {
        var product = GetById(id);

        _products.Products.Remove(product);
        _products.SaveChanges();

        return Ok(new { Message = "Product deleted" });
    }
}
