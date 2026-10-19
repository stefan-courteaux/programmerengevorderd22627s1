using WebShoppie.Api.Contracts;
using WebShoppie.Storage.Customers;
using WebShoppie.Storage.DataModel.Customers;

namespace WebShoppie.Domain.Services.Customers;

public class CustomerService(ICustomerRepository repository) : ICustomerService
{
    public CustomerResponseContract CreateCustomer(CustomerRequestContract customerToCreate)
    {
        var dataModel = new CustomerDataModel()
        {
            FirstName = customerToCreate.FirstName,
            LastName = customerToCreate.LastName,
            Email = customerToCreate.Email,
            Addressline1 = customerToCreate.Addressline1,
            Addressline2 = customerToCreate.Addressline2,
            Addressline3 = customerToCreate.Addressline3,
            Country = customerToCreate.Country,
            DateOfBirth = customerToCreate.DateOfBirth,
            CreationDateTime = DateTime.Now,
        };
        
        // Er is nog geen echt domein model
        
        var createInDb = repository.Create(dataModel);
        
        return new CustomerResponseContract()
        {
            Id = createInDb.Id,
            FirstName = createInDb.FirstName,
            LastName = createInDb.LastName,
            Email = createInDb.Email,
            DateOfBirth =  createInDb.DateOfBirth!.Value,
            Address = createInDb.Addressline1
                      + " " + createInDb.Addressline2
                      + " " + createInDb.Addressline3
                      + " " + createInDb.Country
        };
    }

    public CustomerResponseContract? GetById(int id)
    {
        var dbResult = repository.GetById(id);
        
        if(dbResult is not null)
            return new CustomerResponseContract()
            {
                Id = dbResult.Id,
                FirstName = dbResult.FirstName,
                LastName = dbResult.LastName,
                Email = dbResult.Email,
                DateOfBirth =  dbResult.DateOfBirth!.Value,
                Address = dbResult.Addressline1
                          + " " + dbResult.Addressline2
                          + " " + dbResult.Addressline3
                          + " " + dbResult.Country
            };
        return null;
    }
}