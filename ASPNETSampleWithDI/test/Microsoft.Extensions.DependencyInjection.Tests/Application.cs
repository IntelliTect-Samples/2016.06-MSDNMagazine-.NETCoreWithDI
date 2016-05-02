using System;
using Microsoft.Extensions.Logging;

namespace Microsoft.Extensions.DependencyInjection.Tests
{
public class Application
{
    public IServiceProvider Services { get; set; }
    public ILogger Logger { get; set; }

        public Application(IServiceCollection serviceCollection)
    {
        ConfigureServices(serviceCollection);
        Services = serviceCollection.BuildServiceProvider();
        Logger = Services.GetRequiredService<ILoggerFactory>()
                .CreateLogger<Application>();
        Logger.LogInformation("Application created successfully.");

    }
        
    public void MakePayment(PaymentDetails paymentDetails)
    {
        IPaymentService paymentService = 
            Services.GetRequiredService<IPaymentService>();

        // ...
    }

    private void ConfigureServices(IServiceCollection serviceCollection)
    {
            // Configure additional services here
            // ...
    }
}
}