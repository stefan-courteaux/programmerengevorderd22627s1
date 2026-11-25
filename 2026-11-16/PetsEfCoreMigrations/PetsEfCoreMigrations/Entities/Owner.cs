using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace PetsEfCoreMigrations.Entities;

[Index(nameof(Email), IsUnique = true)]
public class Owner 
{
    public long Id { get; set; } 

    [MaxLength(30)] 
    public string FirstName { get; set; }
    [MaxLength(30)] 
    public string LastName { get; set; }
    [MaxLength(50), EmailAddress] 
    public string Email { get; set; }
    [MaxLength(16), Phone]
    public string PhoneNumber { get; set; }

    public List<Pet> Pets { get; set; } 
}