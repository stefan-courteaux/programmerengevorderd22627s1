using WebShoppie.Api.Contracts.Customer;

namespace WebShoppie.Domain.Services.Interfaces;

public interface ICustomerService
{
    CustomerResponseContract CreateCustomer(CustomerRequestContract customerToCreate);
}