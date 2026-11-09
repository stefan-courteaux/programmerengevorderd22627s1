using WebShoppie.Storage.Entities;

namespace WebShoppie.Storage.Interfaces;

public interface ICustomerRepository
{
    Customer Create(Customer customer); 
    Customer? GetById(int id);
    IEnumerable<Customer> GetAll();
    bool Delete(int customerId);
    Customer Update(Customer customer);
}