namespace WebShoppie.Api.Contracts.Customer;

public class CustomerResponseContract
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Email { get; set; }
    public string Addressline1 { get; set; }
    public string Addressline2 { get; set; }
    public string? Addressline3 { get; set; }
    public string Country { get; set; }   
}