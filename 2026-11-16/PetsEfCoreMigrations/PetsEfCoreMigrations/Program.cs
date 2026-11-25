using Microsoft.EntityFrameworkCore;
using PetsEfCoreMigrations;

Console.WriteLine("Hello, World!");

using var db = new VetDbContext();
db.Database.Migrate();

var ownersWithPetsAndNotes = db.Owners
    .Include(o => o.Pets)
    .ThenInclude(p => p.Notes);

foreach (var owner in ownersWithPetsAndNotes)
{
    Console.WriteLine($"{owner.FirstName} {owner.LastName}, {owner.Email}");
    foreach (var pet in owner.Pets)
    {
        Console.WriteLine($"> {pet.Name} {pet.DateOfBirth}");
        foreach (var note in pet.Notes)
        {
            Console.WriteLine($"  > {note.Content}");
        }
    }
    Console.WriteLine("---");
}