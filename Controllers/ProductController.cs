namespace WebApi.Controllers;

using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Product;
using WebApi.Services;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var products = await _productService.GetAll();
        return Ok(products);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var product = await _productService.GetById(id);
        return Ok(product);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateRequest model)
    {
        await _productService.Create(model);
        return Ok(new { message = "Product created" });
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, UpdateRequest model)
    {
        await _productService.Update(id, model);
        return Ok(new { message = "Product updated" });
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _productService.Delete(id);
        return Ok(new { message = "Product deleted" });
    }
}