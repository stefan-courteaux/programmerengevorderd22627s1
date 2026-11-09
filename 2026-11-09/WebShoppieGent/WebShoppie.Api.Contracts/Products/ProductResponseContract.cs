namespace WebShoppie.Api.Contracts.Products;

public class ProductResponseContract
{
    public int ProductId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int StockCount { get; set; }
}