using Microsoft.AspNetCore.Mvc;
using WebShoppie.Api.Contracts;
using WebShoppie.Api.Contracts.Orders;
using WebShoppie.Domain.Services.Orders;

namespace WebShoppie.Api.Controllers;

[ApiController]
[Route("orders")]
public class OrdersController(IOrderService _service) : ControllerBase
{
    [HttpPost]
    public ActionResult<OrderResponseContract> Create(
        [FromBody] OrderRequestContract orderContract)
    {
        var createdOrder = _service.CreateOrder(orderContract);
        return CreatedAtAction(
            nameof(GetById),
            new { orderId = createdOrder.OrderId },
            createdOrder);
    }

    [HttpGet("{orderId}")]
    public ActionResult<OrderResponseContract> GetById([FromRoute] int orderId)
    {
        var order = _service.GetOrder(orderId);
        if (order is null)
            return NotFound();

        return Ok(order);
    }
}