using System.ComponentModel.DataAnnotations;

namespace PetsEfCoreMigrations.Entities;

public class Note
{
    public long Id { get; set; } 

    [MaxLength(20000)] 
    public string Content { get; set; }
    public DateTime CreationDate { get; set; }

    public Pet Pet { get; set; } 
}