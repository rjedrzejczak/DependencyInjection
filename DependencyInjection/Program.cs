using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Create a list of dependencies
            var services = new ServiceCollection();
            
            // Configurations are heavily used in the .Net Core DI for configuring services, so we can make use of that
            var configurationBuilder = new ConfigurationBuilder();
            
            // Add default configuration file
            configurationBuilder.AddJsonFile("appsettings.json", optional: true);
            
            // Build the configuration
            var configuration = configurationBuilder.Build();

            // Inject the configuration into the DI system
            services.AddSingleton<IConfiguration>(configuration);
            services.AddSingleton<IBusinessLogic, BusinessLogic>();
            
            // At this pointy, all dependencies can be added to the DI system via the service collection
            
            // e.g. services.AddScoped();
            
            // Builder service provider
            var provider = services.BuildServiceProvider();
            
            // At this point, you DI system is ready to go
            // and you can get any services via the provider
            var myConfiguration = provider.GetService<IConfiguration>();

            Console.ReadLine();
        }
    }
}