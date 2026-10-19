using WebShoppie.Storage.DataModel.Customers;

namespace WebShoppie.Storage.Customers;

public interface ICustomerRepository
{
    CustomerDataModel Create(CustomerDataModel customer); 
    CustomerDataModel? GetById(int id);
    List<CustomerDataModel> GetAll();
    bool Delete(int id);
    CustomerDataModel Update(CustomerDataModel customer);
}