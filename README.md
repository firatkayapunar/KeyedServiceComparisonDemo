<h1 align="center">.NET 8 - Keyed Service Örnek Projesi</h1>

<p align="center">
  Bu proje, .NET 8 ile birlikte gelen <strong>Keyed Service</strong> özelliğini <strong>N-Katmanlı Mimari</strong> ile nasıl kullanabileceğimizi gösteren örnek bir uygulamadır.
</p>

---

## 🔧 Kullanılan Teknolojiler

- .NET 8 - .NET 6
- ASP.NET Core Web API
- Katmanlı Mimari (API, Business, Core, Infrastructure)
- Dependency Injection
- Keyed Services

---

## 🎯 Amaç

Bu proje, bir interface'in birden fazla implementasyonu olduğunda, bunların ihtiyaçlara göre nasıl ayrıştırılabileceğini ve .NET 8'in "AddKeyedScoped" ve "GetRequiredKeyedService" gibi yenilikleriyle nasıl kolaylaştığını göstermektedir.

---

<h2>📂 Proje Yapısı</h2>

<pre>
📦 KeyedServiceComparisonDemo
│
├── 📁 AfterKeyedService
│   ├── 📁 AfterKeyedService.API
│   │   ├── 📁 Controllers
│   │   │   ├── EmailController.cs
│   │   ├── Program.cs
│   │
│   ├── 📁 AfterKeyedService.Business
│   │   ├── 📁 (Boş)
│   │
│   ├── 📁 AfterKeyedService.Core
│   │   ├── 📁 Interfaces
│   │   │   ├── IEmailService.cs
│   │
│   ├── 📁 AfterKeyedService.Infrastructure
│   │   ├── 📁 Services
│   │   │   ├── EnglishEmailService.cs
│   │   │   ├── TurkishEmailService.cs
│
├── 📁 BeforeKeyedService
│   ├── 📁 BeforeKeyedService.API
│   │   ├── 📁 Controllers
│   │   │   ├── EmailController.cs
│   │   ├── Program.cs
│   │
│   ├── 📁 BeforeKeyedService.Business
│   │   ├── 📁 Factories
│   │   │   ├── EmailServiceFactory.cs
│   │
│   ├── 📁 BeforeKeyedService.Core
│   │   ├── 📁 Interfaces
│   │   │   ├── IEmailService.cs
│   │
│   ├── 📁 BeforeKeyedService.Infrastructure
│   │   ├── 📁 Services
│   │   │   ├── EnglishEmailService.cs
│   │   │   ├── TurkishEmailService.cs
</pre>
