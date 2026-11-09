using System.ComponentModel.DataAnnotations;

namespace WebShoppie.Api.Contracts.Customers;

public class CustomerRequestContract
{
    [MaxLength(30)]
    public required string FirstName { get; set; }
    [MaxLength(30)]
    public required string LastName { get; set; }
    [Required]
    public required DateTime? DateOfBirth { get; set; }
    [EmailAddress] 
    public required string Email { get; set; }
    [MaxLength(50)]
    public required string Addressline1 { get; set; }
    [MaxLength(50)]
    public required string Addressline2 { get; set; }
    [MaxLength(50)]
    public string? Addressline3 { get; set; }
    [MaxLength(20)]
    public required string Country { get; set; }
}