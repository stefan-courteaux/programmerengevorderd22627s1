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
        //return Ok(_service.CreateCustomer(customerContract));
        var created = _service.CreateCustomer(customerContract);
        return CreatedAtAction(nameof(GetById), new {customerId = created.Id}, created);
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
    public ActionResult<CustomerOverviewResponseContract> GetAll()
    {
        return Ok(_service.GetAll());
    }
    
    [HttpDelete("{customerId}")]
    public IActionResult DeleteById(
        [FromRoute]int customerId)
    {
        var result = _service.Delete(customerId);
        
        if(result)
            return NoContent();//...
        return NotFound();
    }

    [HttpPut("{customerId}")]
    public ActionResult<CustomerResponseContract> UpdateById(
        [FromRoute] int customerId,
        [FromBody] CustomerRequestContract customerContract)
    {
        var updated = _service.Update(customerId, customerContract);
        return Ok(updated);
    }
}