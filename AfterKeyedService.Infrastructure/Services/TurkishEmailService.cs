﻿using AfterKeyedService.Core.Interfaces;

namespace AfterKeyedService.Infrastructure.Services;

public class TurkishEmailService : IEmailService
{
    public void Send(string to, string subject, string body)
    {
        Console.WriteLine($"[TR] '{subject}' başlıklı e-posta {to} adresine gönderiliyor.");
    }
}
