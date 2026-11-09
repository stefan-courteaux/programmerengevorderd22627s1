using WebShoppie.Api.Contracts;
using WebShoppie.Api.Contracts.Customers;

namespace WebShoppie.Domain.Services.Customers;

public interface ICustomerService
{
    CustomerResponseContract CreateCustomer(CustomerRequestContract customerToCreate);
    CustomerResponseContract? GetById(int id);
    IEnumerable<CustomerOverviewResponseContract> GetAllCustomers();
    bool DeleteCustomer(int customerId);
    CustomerResponseContract UpdateCustomer(int id, CustomerRequestContract customerToUpdate);
}