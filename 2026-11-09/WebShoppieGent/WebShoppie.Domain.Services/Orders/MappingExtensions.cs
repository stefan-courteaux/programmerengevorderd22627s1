using WebShoppie.Api.Contracts.Customers;
using WebShoppie.Api.Contracts.Orders;
using WebShoppie.Storage.Entities;

namespace WebShoppie.Domain.Services.Orders;

public static class MappingExtensions
{
    public static OrderResponseContract AsContract(
        this Order order,
        IEnumerable<OrderProductResponseContract> orderProducts,
        CustomerResponseContract customer)
    {
        return new OrderResponseContract
        {
            OrderId = order.Orderid,
            OrderDate = order.Orderdate,
            CustomerId = order.Customerid,
            TotalPrice = order.Totalprice,
            CustomerEmail = customer.Email,
            OrderProducts = orderProducts
        };
    }

    public static OrderProductResponseContract AsContract(
        this Orderproduct orderProduct,
        string productName)
    {
        return new OrderProductResponseContract
        {
            OrderProductId = orderProduct.Orderproductid,
            OrderId = orderProduct.Orderid,
            ProductId = orderProduct.Productid,
            ProductName = productName,
            Quantity = orderProduct.Quantity,
            Price = orderProduct.Price
        };
    }
}