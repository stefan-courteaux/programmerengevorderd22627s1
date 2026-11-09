using Microsoft.AspNetCore.Mvc;
using WebShoppie.Api.Contracts;
using WebShoppie.Api.Contracts.Customers;
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

    [HttpGet]
    public ActionResult<IEnumerable<CustomerOverviewResponseContract>> GetAllCustomers()
    {
        return Ok(_service.GetAllCustomers());
    }

    [HttpDelete("{customerId}")]
    public IActionResult Delete([FromRoute] int customerId)
    {
        if(_service.DeleteCustomer(customerId)) 
            return NoContent();
        
        return BadRequest();
    }

    [HttpPut("{customerId}")]
    public ActionResult<CustomerResponseContract> Update(
        [FromRoute] int customerId, [FromBody] CustomerRequestContract customerContract)
    {
        var updated = _service.UpdateCustomer(customerId, customerContract);
        return Ok(updated);
    }
}

