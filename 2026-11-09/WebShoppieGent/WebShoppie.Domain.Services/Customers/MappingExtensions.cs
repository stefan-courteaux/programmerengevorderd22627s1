using WebShoppie.Api.Contracts;
using WebShoppie.Api.Contracts.Customers;
using WebShoppie.Storage.Entities;

namespace WebShoppie.Domain.Services.Customers;

public static class MappingExtensions
{
    public static CustomerResponseContract AsContract(this Customer dataModel)
    {
        return new CustomerResponseContract
        {
            Id = dataModel.Customerid,
            FirstName = dataModel.Firstname,
            LastName = dataModel.Lastname,
            Email = dataModel.Email,
            DateOfBirth =  dataModel.Dateofbirth,
            Address = dataModel.Addressline1
                      + " " + dataModel.Addressline2
                      + " " + dataModel.Addressline3
                      + " " + dataModel.Country
        };
    }
    
    public static CustomerOverviewResponseContract AsOverviewContract(this Customer dataModel)
    {
        return new CustomerOverviewResponseContract
        {
            Id = dataModel.Customerid,
            Country = dataModel.Country,
            Email = dataModel.Email,
            SalesTotal = 9000.0
        };
    }
    
    public static Customer AsDataModel(this CustomerRequestContract contract)
    {
        return new Customer()
        {
            Firstname = contract.FirstName,
            Lastname = contract.LastName,
            Email = contract.Email,
            Addressline1 = contract.Addressline1,
            Addressline2 = contract.Addressline2,
            Addressline3 = contract.Addressline3,
            Country = contract.Country,
            Dateofbirth = contract.DateOfBirth!.Value
        };
    }
    
}