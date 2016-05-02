
using Microsoft.Extensions.DependencyInjection.Tests.Mocks;
using Microsoft.Extensions.Logging;

namespace Microsoft.Extensions.DependencyInjection.Tests
{
    public class Host
    {
        public static void Main()
        {
            IServiceCollection serviceCollection = new ServiceCollection();

            #region Register test mocks in IoC container.

            serviceCollection.AddInstance<ILoggerFactory>( new LoggerFactory() );
            serviceCollection.AddTransient<IPaymentService, MockPaymentService>();

            #endregion

            Application application = new Application(serviceCollection);

            // Run
            // ...
            application.MakePayment(null);
        }
    }
}
