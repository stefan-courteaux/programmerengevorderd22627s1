namespace WebShoppie.Api.Contracts.Orders;

public class OrderResponseContract
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public int CustomerId { get; set; }
    public string CustomerEmail { get; set; }
    public decimal TotalPrice { get; set; }
    public IEnumerable<OrderProductResponseContract> OrderProducts { get; set; }
}

public class OrderProductResponseContract
{
    public int OrderProductId { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}