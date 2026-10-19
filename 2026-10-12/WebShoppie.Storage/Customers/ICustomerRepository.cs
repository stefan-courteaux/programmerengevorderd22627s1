using WebShoppie.Storage.DataModel.Customers;

namespace WebShoppie.Storage.Customers;

public interface ICustomerRepository
{
    CustomerDataModel Create(CustomerDataModel customer); 
    CustomerDataModel? GetById(int id);
}