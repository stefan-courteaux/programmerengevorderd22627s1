using Microsoft.EntityFrameworkCore;
using WebShoppie.Storage.Entities;
using WebShoppie.Storage.Interfaces;

namespace WebShoppie.Storage.Repositories;

public class OrderRepository(WebShoppieDbContext _dbContext) : IOrderRepository
{
    public Order Create(Order order, IEnumerable<Orderproduct> orderProducts)
    {
        order.Orderproducts = orderProducts.ToList();
        _dbContext.Orders.Add(order);
        _dbContext.SaveChanges();
        return order;
    }

    public Order? Get(int id)
    {
        return _dbContext.Orders.Find(id);
    }

    public IEnumerable<Orderproduct> GetOrderProducts(int orderId)
    {
        return _dbContext.Orderproducts.Where(op => op.Orderid == orderId);
    }

    public IEnumerable<Order> GetAll()
    {
        return _dbContext.Orders;
    }

    public Order? GetFullOrder(int id)
    {
        return _dbContext.Orders
            .Include(o => o.Customer)
            .Include(o => o.Orderproducts)
            .ThenInclude(op => op.Product)
            .SingleOrDefault(o => o.Orderid == id);
    }
}