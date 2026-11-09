using WebShoppie.Api.Contracts;
using WebShoppie.Api.Contracts.Products;

namespace WebShoppie.Domain.Services.Products;

public interface IProductService
{
    ProductResponseContract CreateProduct(ProductRequestContract productToCreate);
    ProductResponseContract? GetById(int id);
    IEnumerable<ProductResponseContract> GetAllProducts();
    bool DeleteProduct(int productId);
    ProductResponseContract UpdateProduct(int id, ProductRequestContract productToUpdate);
}