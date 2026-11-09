using WebShoppie.Storage.Entities;

namespace WebShoppie.Storage.Interfaces;

public interface IProductRepository
{
    Product Create(Product product);
    Product? GetById(int id);
    IEnumerable<Product> GetAll();
    bool Delete(int productId);
    Product Update(Product product);
}