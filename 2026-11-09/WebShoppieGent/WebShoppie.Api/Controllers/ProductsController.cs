using Microsoft.AspNetCore.Mvc;
using WebShoppie.Api.Contracts;
using WebShoppie.Api.Contracts.Products;
using WebShoppie.Domain.Services.Products;

namespace WebShoppie.Api.Controllers;

[ApiController]
[Route("products")]
public class ProductsController(IProductService _service) : ControllerBase
{
    [HttpPost]
    public ActionResult<ProductResponseContract> Create(
        [FromBody] ProductRequestContract productContract)
    {
        var createdProduct = _service.CreateProduct(productContract);
        return CreatedAtAction(
            nameof(GetById),
            new { productId = createdProduct.ProductId },
            createdProduct);
    }

    [HttpGet("{productId}")]
    public ActionResult<ProductResponseContract> GetById([FromRoute] int productId)
    {
        var product = _service.GetById(productId);
        if (product is null)
            return NotFound();

        return Ok(product);
    }

    [HttpGet]
    public ActionResult<IEnumerable<ProductResponseContract>> GetAllProducts()
    {
        return Ok(_service.GetAllProducts());
    }

    [HttpDelete("{productId}")]
    public IActionResult Delete([FromRoute] int productId)
    {
        if (_service.DeleteProduct(productId))
            return NoContent();

        return BadRequest();
    }

    [HttpPut("{productId}")]
    public ActionResult<ProductResponseContract> Update(
        [FromRoute] int productId, [FromBody] ProductRequestContract productContract)
    {
        var updated = _service.UpdateProduct(productId, productContract);
        return Ok(updated);
    }
}