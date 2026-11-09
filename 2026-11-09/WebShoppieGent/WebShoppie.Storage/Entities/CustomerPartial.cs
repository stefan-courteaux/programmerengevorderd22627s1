namespace WebShoppie.Storage.Entities;

public partial class Customer
{
    public int Age => DateTime.Now.Year - Dateofbirth.Year;
}