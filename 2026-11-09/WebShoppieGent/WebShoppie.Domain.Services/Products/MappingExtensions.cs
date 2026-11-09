using WebShoppie.Api.Contracts.Products;
using WebShoppie.Storage.Entities;

namespace WebShoppie.Domain.Services.Products;

public static class MappingExtensions
{
    public static ProductResponseContract AsContract(this Product dataModel)
    {
        return new ProductResponseContract
        {
            ProductId = dataModel.Productid,
            Title = dataModel.Title,
            Description = dataModel.Description,
            Price = dataModel.Price,
            StockCount = dataModel.Stockcount
        };
    }

    public static Product AsEntity(this ProductRequestContract contract)
    {
        return new Product
        {
            Title = contract.Title,
            Description = contract.Description,
            Price = contract.Price,
            Stockcount = contract.StockCount
        };
    }
}