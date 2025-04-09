<h1 align="center">.NET 8 - Keyed Service Karşılaştırmalı Örnek Projesi</h1>

<p align="center">
Bu proje, <strong>.NET 8</strong> ile gelen <strong>Keyed Services</strong> özelliğini <strong>N-Layer Architecture</strong> ile uygulamalı olarak göstermektedir.<br />
Proje ayrıca, aynı senaryonun <strong>.NET 6</strong>'da <strong>Factory Pattern</strong> kullanılarak nasıl çözüldüğünü de içermekte ve iki yaklaşımı karşılaştırmaktadır.
</p>


---

## 🔧 Kullanılan Teknolojiler

- .NET 8 & .NET 6
- ASP.NET Core Web API
- N-Layer Architecture (API, Business, Core, Infrastructure)
- Dependency Injection
- Keyed Services
  
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
