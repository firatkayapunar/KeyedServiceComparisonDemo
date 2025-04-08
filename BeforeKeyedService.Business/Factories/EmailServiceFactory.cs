using BeforeKeyedService.Core.Interfaces;
using BeforeKeyedService.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BeforeKeyedService.Business.Factories;

// Factory, hangi implementasyonu neye göre kullanacağımızı merkezi bir yerde çözmek için kullanıldı.
public class EmailServiceFactory
{
    private readonly IServiceProvider _serviceProvider;

    public EmailServiceFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public IEmailService GetService(string lang)
    {
        return lang.ToLower() switch
        {
            "en" => _serviceProvider.GetRequiredService<EnglishEmailService>(),
            "tr" => _serviceProvider.GetRequiredService<TurkishEmailService>(),
            _ => throw new NotSupportedException($"Language '{lang}' is not supported.")
        };
    }
}
