using WebShoppie.Api.Contracts;
using WebShoppie.Api.Contracts.Customers;
using WebShoppie.Storage.DataModel.Customers;

namespace WebShoppie.Domain.Services.Customers;

public static class CustomerMappingExtensions
{
    public static CustomerResponseContract AsContract(this CustomerDataModel dataModel)
    {
        return new CustomerResponseContract()
        {
            Id = dataModel.CustomerId,
            FirstName = dataModel.FirstName,
            LastName = dataModel.LastName,
            Email = dataModel.Email,
            DateOfBirth =  dataModel.DateOfBirth!.Value,
            Address = dataModel.Addressline1
                      + " " + dataModel.Addressline2
                      + " " + dataModel.Addressline3
                      + " " + dataModel.Country
        };
    }
    
    public static CustomerOverviewResponseContract AsOverviewContract(this CustomerDataModel dataModel)
    {
        return new CustomerOverviewResponseContract()
        {
            Id = dataModel.CustomerId,
            Email = dataModel.Email,
            LastOrderDate = DateTime.MinValue// TODO
        };
    }
    
    public static CustomerDataModel AsDataModel(this CustomerRequestContract contract)
    {
        return new CustomerDataModel()
        {
            FirstName = contract.FirstName,
            LastName = contract.LastName,
            Email = contract.Email,
            Addressline1 = contract.Addressline1,
            Addressline2 = contract.Addressline2,
            Addressline3 = contract.Addressline3,
            Country = contract.Country,
            DateOfBirth = contract.DateOfBirth,
            CreationDateTime = DateTime.Now,
        };
    }
}