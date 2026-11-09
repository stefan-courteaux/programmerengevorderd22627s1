using WebShoppie.Api.Contracts;
using WebShoppie.Api.Contracts.Orders;

namespace WebShoppie.Domain.Services.Orders;

public interface IOrderService
{
    OrderResponseContract CreateOrder(OrderRequestContract orderToCreate);
    OrderResponseContract? GetOrder(int id);
}