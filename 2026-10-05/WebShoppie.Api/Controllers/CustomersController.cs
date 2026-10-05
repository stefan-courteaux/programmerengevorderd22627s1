using Microsoft.AspNetCore.Mvc;
using WebShoppie.Api.Contracts.Customer;
using WebShoppie.Domain.Services.Implementations;
using WebShoppie.Domain.Services.Interfaces;

namespace WebShoppie.Api.Controllers;

[ApiController]
[Route("customers")]
public class CustomersController(ICustomerService customerService) 
    : ControllerBase
{
    [HttpPost]
    public IActionResult Create(
        [FromBody] CustomerRequestContract requestContract)
    {
        customerService.CreateCustomer(requestContract);
        return Ok("Jajaa het is gemaakt");
    }
}