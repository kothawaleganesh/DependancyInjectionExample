# DIExample

This project demonstrates the basics of Dependency Injection (DI) in C# using .NET 9 and Microsoft.Extensions.DependencyInjection.

## Key Concepts

- **Dependency Injection (DI):** A design pattern that promotes loose coupling by injecting dependencies (services) into classes rather than creating them directly.
- **Service Lifetimes:**
  - **Transient:** A new instance is provided every time the service is requested.
  - **Scoped:** A single instance is provided within a scope (commonly per web request).
  - **Singleton:** A single instance is used throughout the application's lifetime.

## Types of Dependency Injection Demonstrated

- **Constructor Injection:** Dependencies are provided through the class constructor (recommended approach).
- **Property Injection:** Dependencies are set via public properties.
- **Method Injection:** Dependencies are passed as parameters to methods.

## Project Structure

- `IMessageService`: Interface defining a message service.
- `TransientMessageService`: Implementation of `IMessageService`.
- `ConstructorInjected`: Demonstrates constructor injection.
- `PropertyInjected`: Demonstrates property injection.
- `MethodInjected`: Demonstrates method injection.
- `Program.cs`: Configures DI and demonstrates usage.

## How to Run

1. Build the project using Visual Studio or `dotnet build`.
2. Run the project using Visual Studio or `dotnet run`.

## Example Output

The program will demonstrate the use of DI by running each injection type and showing the service's unique identifier.

## Requirements

- .NET 9 SDK
- Microsoft.Extensions.DependencyInjection NuGet package

## License

This example is provided for educational purposes.
