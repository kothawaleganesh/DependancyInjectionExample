// DI -- Dependancy injection
// -- promotes loose coupling
// Dependancy -- an object or service that a class required to perform it's function
// Types of dependancy injections
// -- Constructor Injection -- provided through class constructor -- most common and recommended approach
// -- Property / Setter -- provided throught public properties or setter methods
// -- method injections  -- provided through passed as a specific method when that method is called
// benefits --
// Loose coupling
// Testablility.
// enhanced maintainability 
// reusability

// Service Lifetime--
// -- 1. transient -- New instance everytime when it's requested
// -- 2. scoped -- Same instance per request -- usually in Web
// -- 3. Singleton -- Application lifetime

using DIExample;
using DIExample.Classes;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    private static void Main(string[] args)
    {
        var services = new ServiceCollection();
        services.AddSingleton<IMessageService, TransientMessageService>();
        var provider = services.BuildServiceProvider();

        var property = new PropertyInjected
        {
            _iMessageService = provider.GetService<IMessageService>()
        };
       property.Run();

        var mi = new MethodInjected();
        mi.Run(provider.GetService<IMessageService>());

       var constructorService = new ConstructorInjected(provider.GetService<IMessageService>());
        constructorService.Run();

        //for (int i = 1; i <= 3; i++)
        //{
        //    var service = provider.GetService<IMessageService>();
        //    Console.WriteLine($"Transient Call:{i}  ServiceId:{service.Id}");
        //    Transient Call:1  ServiceId: 1ad9a90f - 6974 - 4912 - a9fc - 0c0970b4ffa6
        //    Transient Call: 2  ServiceId: dc239c38 - 38ba - 424a - a3a8 - 470b44fb4867
        //    Transient Call: 3  ServiceId: b5484c37 - af3b - 4798 - af49 - 43ad07f62228
        //}

        //for (int i = 1; i <= 3; i++)
        //{
        //    using (var scope = provider.CreateScope())
        //    {
        //        var service = provider.GetService<IMessageService>();
        //        Console.WriteLine($"scoped Call:{i}  ServiceId:{service.Id}");
        //    }
        //    Singleton Call:1  ServiceId: 8ab6f3ba - b469 - 475d - a44a - a0d1eb9b6d4d
        //    Singleton Call:2  ServiceId: 8ab6f3ba - b469 - 475d - a44a - a0d1eb9b6d4d
        //    Singleton Call:3  ServiceId: 8ab6f3ba - b469 - 475d - a44a - a0d1eb9b6d4d
        //}

        //for (int i = 1; i <= 3; i++)
        //{
        //    using (var scope = provider.CreateScope())
        //    {
        //        var service = provider.GetService<IMessageService>();
        //        Console.WriteLine($"scoped Call:{i}  ServiceId:{service.Id}");
        //    }
        //    Singleton Call:1  ServiceId: 8ab6f3ba - b469 - 475d - a44a - a0d1eb9b6d4d
        //    Singleton Call:2  ServiceId: 8ab6f3ba - b469 - 475d - a44a - a0d1eb9b6d4d
        //    Singleton Call:3  ServiceId: 8ab6f3ba - b469 - 475d - a44a - a0d1eb9b6d4d
        //}
        Console.ReadLine();
    }
}