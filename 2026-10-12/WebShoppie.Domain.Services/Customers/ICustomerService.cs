using WebShoppie.Api.Contracts;

namespace WebShoppie.Domain.Services.Customers;

public interface ICustomerService
{
    CustomerResponseContract CreateCustomer(CustomerRequestContract customerToCreate);
    CustomerResponseContract? GetById(int id);
}