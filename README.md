# Serilog.Enrichers.MemoryUsage [![Nuget](https://img.shields.io/nuget/v/Serilog.Enrichers.MemoryUsage.svg)](https://nuget.org/packages/Serilog.Enrichers.MemoryUsage/)
Enriches Serilog events with information of the memory usage.

Install the _Serilog.Enrichers.MemoryUsage_ [NuGet package](https://www.nuget.org/packages/Serilog.Enrichers.MemoryUsage/)

```powershell
Install-Package Serilog.Enrichers.MemoryUsage
```
or
```shell
dotnet add package Serilog.Enrichers.MemoryUsage
```

Apply the enricher to your `LoggerConfiguration` in code:

```csharp
Log.Logger = new LoggerConfiguration()
    .Enrich.WithMemoryUsage()
    // ...other configuration...
    .CreateLogger();
```

or in `appsettings.json` file:
```json
{
  "Serilog": {
    "MinimumLevel": "Verbose",
    "Using":  [ "Serilog.Enrichers.MemoryUsage" ],
    "Enrich": [
      "WithMemoryUsage"
    ],
    "WriteTo": [
      { "Name": "Console" }
    ]
  }
}
```

#### Note
To include logged headers in `OutputTemplate` use `MemoryUsage`.
```csharp
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Verbose()
    .Enrich.WithMemoryUsage()
    .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss}] {Level:u3} MemoryUsage: {MemoryUsage} {Message:lj}{NewLine}{Exception}")
```
