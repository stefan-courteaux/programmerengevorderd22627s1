namespace WebShoppie.Api.Contracts.Customers;

public class CustomerOverviewResponseContract
{
    public int Id { get; set; }
    public string Email { get; set; }
    public DateTime LastOrderDate { get; set; }//TODO
}