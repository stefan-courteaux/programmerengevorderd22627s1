namespace WebShoppie.Api.Contracts.Customers;

public class CustomerOverviewResponseContract
{
    public int Id { get; set; }
    public string Country { get; set; }
    public string Email { get; set; }
    public double SalesTotal { get; set; }
}