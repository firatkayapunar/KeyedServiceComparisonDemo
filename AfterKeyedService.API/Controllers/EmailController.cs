using Microsoft.AspNetCore.Mvc;
using AfterKeyedService.Core.Interfaces;

namespace AfterKeyedService.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmailController : ControllerBase
{
    private readonly IServiceProvider _provider;

    public EmailController(IServiceProvider provider)
    {
        _provider = provider;
    }

    [HttpPost]
    public IActionResult Send([FromQuery] string lang, [FromQuery] string to)
    {
        var emailService = _provider.GetRequiredKeyedService<IEmailService>(lang);
        emailService.Send(to, "Invoice", "Your invoice is attached.");
        return Ok($"Email sent via keyed service for lang '{lang}'");
    }
}
