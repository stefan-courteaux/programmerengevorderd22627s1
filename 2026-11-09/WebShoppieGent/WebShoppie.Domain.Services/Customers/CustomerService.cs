using WebShoppie.Api.Contracts.Customers;
using WebShoppie.Storage.Interfaces;

namespace WebShoppie.Domain.Services.Customers;

public class CustomerService(ICustomerRepository repository) : ICustomerService
{
    public CustomerResponseContract CreateCustomer(CustomerRequestContract customerToCreate)
    {
        var dataModel = customerToCreate.AsDataModel();
        
        // Er is nog geen echt domein model nodig.
        
        var createInDb = repository.Create(dataModel);

        return createInDb.AsContract();
    }

    public CustomerResponseContract? GetById(int id)
    {
        var dbResult = repository.GetById(id);

        if (dbResult is not null)
            return dbResult.AsContract();
        
        return null;
    }

    public IEnumerable<CustomerOverviewResponseContract> GetAllCustomers()
    {
        var dbResult = repository.GetAll();
        return dbResult.Select(customer => customer.AsOverviewContract());
    }

    public bool DeleteCustomer(int customerId)
    {
        return repository.Delete(customerId);
    }

    public CustomerResponseContract UpdateCustomer(int id, CustomerRequestContract customerToUpdate)
    {
        var dataModel = customerToUpdate.AsDataModel();
        dataModel.Customerid = id;

        var updated = repository.Update(dataModel);
        
        return updated.AsContract();
    }
}