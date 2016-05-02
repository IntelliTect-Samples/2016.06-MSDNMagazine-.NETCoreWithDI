using Microsoft.Extensions.Logging;

namespace Microsoft.Extensions.DependencyInjection.Tests.Mocks
{
    public static class CustomLoggerFactoryExtensions
    {
        public static ILoggerFactory AddCustomLogger(
            this ILoggerFactory factory, out CustomLoggerProvider logProvider)
        {
            logProvider = new CustomLoggerProvider();
            factory.AddProvider(logProvider);
            return factory;
        }
    }
}
