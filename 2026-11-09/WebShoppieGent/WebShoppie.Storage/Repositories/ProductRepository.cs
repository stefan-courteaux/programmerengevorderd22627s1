using WebShoppie.Storage.Entities;
using WebShoppie.Storage.Interfaces;

namespace WebShoppie.Storage.Repositories;

public class ProductRepository (WebShoppieDbContext _dbContext) : IProductRepository
{
    public Product Create(Product product)
    {
        _dbContext.Products.Add(product);
        _dbContext.SaveChanges();
        return product;
    }

    public Product? GetById(int id)
    {
        return _dbContext.Products.Find(id);
    }

    public IEnumerable<Product> GetAll()
    {
        return _dbContext.Products;
    }

    public bool Delete(int productId)
    {
        var existingProduct = _dbContext.Products.Find(productId);
        if (existingProduct is null)
            return false;
        _dbContext.Products.Remove(existingProduct);
        _dbContext.SaveChanges();
        return true;
    }

    public Product Update(Product product)
    {
        _dbContext.Products.Update(product);
        _dbContext.SaveChanges();
        return product;
    }
}