using BeforeKeyedService.Core.Interfaces;

namespace BeforeKeyedService.Infrastructure.Services;

public class EnglishEmailService : IEmailService
{
    public void Send(string to, string subject, string body)
    {
        Console.WriteLine($"[EN] Sending '{subject}' to {to}");
    }
}
