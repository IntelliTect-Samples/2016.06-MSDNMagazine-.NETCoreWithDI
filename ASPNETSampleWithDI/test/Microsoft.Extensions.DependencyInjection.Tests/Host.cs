
namespace Microsoft.Extensions.DependencyInjection.Tests
{
    public class Host
    {
        public static void Main()
        {
            IServiceCollection serviceCollection = new ServiceCollection();

            Application application = new Application(serviceCollection);

            // Run
            // ...
            application.MakePayment(null);
        }
    }
}
