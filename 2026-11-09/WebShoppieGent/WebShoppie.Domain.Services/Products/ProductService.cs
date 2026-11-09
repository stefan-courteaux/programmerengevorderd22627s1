using WebShoppie.Api.Contracts.Products;
using WebShoppie.Storage.Interfaces;

namespace WebShoppie.Domain.Services.Products;

public class ProductService(IProductRepository repository) : IProductService
{
    public ProductResponseContract CreateProduct(ProductRequestContract productToCreate)
    {
        var dataModel = productToCreate.AsEntity();
        var created = repository.Create(dataModel);

        return created.AsContract();
    }

    public ProductResponseContract? GetById(int id)
    {
        var product = repository.GetById(id);

        return product?.AsContract();
    }

    public IEnumerable<ProductResponseContract> GetAllProducts()
    {
        return repository.GetAll().Select(product => product.AsContract());
    }

    public bool DeleteProduct(int productId)
    {
        return repository.Delete(productId);
    }

    public ProductResponseContract UpdateProduct(int id, ProductRequestContract productToUpdate)
    {
        var dataModel = productToUpdate.AsEntity();
        dataModel.Productid = id;
        var updated = repository.Update(dataModel);

        return updated.AsContract();
    }
}