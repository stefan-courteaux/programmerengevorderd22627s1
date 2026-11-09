using System.ComponentModel.DataAnnotations;

namespace WebShoppie.Api.Contracts.Products;

public class ProductRequestContract
{
    [MaxLength(40)]
    public required string Title { get; init; }
    [MaxLength(100)]
    public required string Description { get; init; }
    [Range(0, 10000)]
    public decimal Price { get; init; }
    [Range(0, 1000)]
    public int StockCount { get; init; }
}