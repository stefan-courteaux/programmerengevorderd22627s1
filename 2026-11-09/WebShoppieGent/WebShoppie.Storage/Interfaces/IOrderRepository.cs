
using WebShoppie.Storage.Entities;

namespace WebShoppie.Storage.Interfaces;

public interface IOrderRepository
{
    Order Create(Order order, IEnumerable<Orderproduct> orderProducts);
    Order? Get(int id);
    IEnumerable<Orderproduct> GetOrderProducts(int orderId);
    IEnumerable<Order> GetAll();
    Order? GetFullOrder(int id);
}