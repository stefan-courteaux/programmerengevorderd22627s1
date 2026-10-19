using WebShoppie.Api.Contracts;
using WebShoppie.Api.Contracts.Customers;
using WebShoppie.Storage.Customers;
using WebShoppie.Storage.DataModel.Customers;

namespace WebShoppie.Domain.Services.Customers;

public class CustomerService(ICustomerRepository repository) : ICustomerService
{
    public CustomerResponseContract CreateCustomer(CustomerRequestContract customerToCreate)
    {
        // Er is nog geen echt domein model
        return repository.Create(customerToCreate.AsDataModel())
            .AsContract();
    }

    public CustomerResponseContract? GetById(int id)
    {
        return repository.GetById(id)?.AsContract();
    }

    public List<CustomerOverviewResponseContract> GetAll()
    {
        return repository.GetAll()
            .Select(dbCustomer => dbCustomer.AsOverviewContract())
            .ToList();
    }

    public CustomerResponseContract Update(int id, CustomerRequestContract customerToUpdate)
    {
        if(repository.GetById(id) == null)
            throw new Exception("Customer not found");// TODO define custom exception

        var asDataModel = customerToUpdate.AsDataModel();
        asDataModel.CustomerId = id;
        
        return repository.Update(asDataModel).AsContract();
    }

    public bool Delete(int id)
    {
        return repository.Delete(id);
    }
    
}