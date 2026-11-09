using System.ComponentModel.DataAnnotations;

namespace WebShoppie.Api.Contracts.Orders;

public class OrderRequestContract
{
    [Required]
    public int CustomerId { get; set; }
    [Required]
    public required IEnumerable<OrderProductRequestContract> OrderProducts { get; set; }
}

public class OrderProductRequestContract
{
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}