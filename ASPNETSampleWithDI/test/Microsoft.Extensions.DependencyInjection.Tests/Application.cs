using System;
using Microsoft.Extensions.Logging;

namespace Microsoft.Extensions.DependencyInjection.Tests
{
    public class Application
    {
        public Application( IServiceCollection serviceCollection )
        {
            ConfigureServices( serviceCollection );
            Services = serviceCollection.BuildServiceProvider();
            Logger = Services.GetRequiredService<ILoggerFactory>()
                    .CreateLogger<Application>();
            Logger.LogInformation( "Application created successfully." );
        }

        public IServiceProvider Services { get; set; }
        public ILogger Logger { get; set; }

        public void MakePayment( PaymentDetails paymentDetails )
        {
            var paymentService =
                    Services.GetRequiredService<IPaymentService>();

            // ...
        }

        private void ConfigureServices( IServiceCollection serviceCollection )
        {
            // Configure additional services here
            // ...
        }
    }
}