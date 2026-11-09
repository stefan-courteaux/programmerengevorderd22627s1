using WebShoppie.Storage.Entities;
using WebShoppie.Storage.Interfaces;

namespace WebShoppie.Storage.Repositories;

public class CustomerRepository(WebShoppieDbContext _dbContext) : ICustomerRepository
{
    public Customer Create(Customer customer)
    {
        _dbContext.Customers.Add(customer);
        _dbContext.SaveChanges();
        return customer;
    }

    public Customer? GetById(int id)
    {
        return _dbContext.Customers.Find(id);
    }

    public IEnumerable<Customer> GetAll()
    {
        return _dbContext.Customers;
    }

    public bool Delete(int customerId)
    {
        var existing = _dbContext.Customers.Find(customerId);
        if (existing is null)
            return false;
        _dbContext.Customers.Remove(existing);
        _dbContext.SaveChanges();
        return true;
    }

    public Customer Update(Customer customer)
    {
        _dbContext.Customers.Update(customer);
        _dbContext.SaveChanges();
        return customer;
    }
}