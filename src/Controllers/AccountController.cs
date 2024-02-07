using Microsoft.AspNetCore.Mvc;
using PloomesClient.Dtos;
using PloomesClient.Services;

namespace PloomesClient.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountController(IAccountService service) : ControllerBase
{

    [HttpGet()]
    public IActionResult Get()
    {
        return Ok(" Account controller works");
    }

    [HttpPost()]
    public IActionResult Create([FromBody] AccountCreateDto input) {
        try {
            return Created("", service.Create(input));
        } catch (BadHttpRequestException e) {
            return StatusCode(e.StatusCode, e.Message);
        }
    }
}
