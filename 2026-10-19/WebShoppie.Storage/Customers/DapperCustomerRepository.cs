using Dapper;
using Npgsql;
using WebShoppie.Storage.DataModel.Customers;

namespace WebShoppie.Storage.Customers;

public class DapperCustomerRepository : ICustomerRepository
{
    private readonly string connectionstring = "Server=localhost;Port=5432;Userid=admin;Password=secret;Database=pg2db";
    
    public CustomerDataModel Create(CustomerDataModel customer)
    {
        const string query =
            @"INSERT INTO storefront.customers(
            firstname, lastname, dateofbirth, email,
            addressline1, addressline2, addressline3, country)
                  VALUES (@firstname, @lastname, @dateofbirth, @email,
            @addressline1, @addressline2, @addressline3, @country)
                  RETURNING CustomerId"; 

        using var connection = new NpgsqlConnection(connectionstring);

        var id = connection.ExecuteScalar<int>(query, customer); 

        return GetById(id) ?? throw new Exception( 
            $"Cust {customer.FirstName} could not be created"
        );    
    }

    public CustomerDataModel? GetById(int id)
    {
        const string query = "SELECT * FROM storefront.customers WHERE customerid = @customerid";
        using var connection = new NpgsqlConnection(connectionstring);
        var customer = connection.QuerySingleOrDefault<CustomerDataModel>(query, new { customerid = id });
        return customer;
    }

    public List<CustomerDataModel> GetAll()
    {
        throw new NotImplementedException();
    }

    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }

    public CustomerDataModel Update(CustomerDataModel customer)
    {
        throw new NotImplementedException();
    }
}