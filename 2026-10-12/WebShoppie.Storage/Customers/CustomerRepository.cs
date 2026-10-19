using WebShoppie.Storage.DataModel.Customers;

namespace WebShoppie.Storage.Customers;

public class CustomerRepository : ICustomerRepository
{
    private readonly Dictionary<int, CustomerDataModel> _dataModels = new();
    
    public CustomerDataModel Create(CustomerDataModel customer)
    {
        // Id bepalen - super crappy in memory
        var newId = 1;
        if (_dataModels.Keys.Any())
            newId = _dataModels.Keys.Max() + 1;

        // customer toevoegen
        _dataModels[newId] = customer;
        customer.Id = newId;
        
        //customer returnen uit db
        return _dataModels[newId];
    }

    public CustomerDataModel? GetById(int id)
    {
        return _dataModels.GetValueOrDefault(id);
    }
}