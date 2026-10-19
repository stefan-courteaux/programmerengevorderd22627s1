using Microsoft.AspNetCore.Mvc;
using WebShoppie.Api.Contracts;
using WebShoppie.Domain.Services.Customers;

namespace WebShoppie.Api.Controllers;

[ApiController]
[Route("customers")]
public class CustomersController(ICustomerService _service) : ControllerBase
{
    [HttpPost]
    public ActionResult<CustomerResponseContract> Create(
        [FromBody]CustomerRequestContract customerContract)
    {
        return Ok(_service.CreateCustomer(customerContract));
    }

    [HttpGet("{customerId}")]
    public ActionResult<CustomerResponseContract> GetById(
        [FromRoute]int customerId)
    {
        var customer = _service.GetById(customerId);
        if(customer is null)
            return NotFound();
        return Ok(customer);
    }
}