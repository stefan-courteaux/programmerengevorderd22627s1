using WebShoppie.Api.Contracts;
using WebShoppie.Api.Contracts.Customers;

namespace WebShoppie.Domain.Services.Customers;

public interface ICustomerService
{
    CustomerResponseContract CreateCustomer(CustomerRequestContract customerToCreate);
    CustomerResponseContract? GetById(int id);
    List<CustomerOverviewResponseContract> GetAll();
    CustomerResponseContract Update(int id, CustomerRequestContract customerToUpdate);
    bool Delete(int id);
}