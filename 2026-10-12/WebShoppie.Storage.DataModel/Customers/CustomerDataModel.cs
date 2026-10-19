namespace WebShoppie.Storage.DataModel.Customers;

public class CustomerDataModel
{
    public int Id { get; set; }
    public DateTime CreationDateTime { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string Email { get; set; }
    public string Addressline1 { get; set; }
    public string Addressline2 { get; set; }
    public string? Addressline3 { get; set; }
    public string Country { get; set; }
    public string InternalNotes { get; set; }
}