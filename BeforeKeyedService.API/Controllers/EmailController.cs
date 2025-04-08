using BeforeKeyedService.Business.Factories;
using Microsoft.AspNetCore.Mvc;

namespace BeforeKeyedService.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmailController : ControllerBase
{
    private readonly EmailServiceFactory _factory;

    public EmailController(EmailServiceFactory factory)
    {
        _factory = factory;
    }

    [HttpPost]
    public IActionResult Send([FromQuery] string lang, [FromQuery] string to)
    {
        var service = _factory.GetService(lang);
        service.Send(to, "Invoice", "Your invoice is attached.");
        return Ok("Email sent successfully.");
    }
}
