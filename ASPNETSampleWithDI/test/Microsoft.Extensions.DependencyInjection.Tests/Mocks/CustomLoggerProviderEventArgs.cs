namespace Microsoft.Extensions.DependencyInjection.Tests.Mocks
{
    public class CustomLoggerProviderEventArgs
    {
        public CustomLogger CustomLogger { get; }
        public CustomLoggerProviderEventArgs(CustomLogger logger)
        {
            CustomLogger = logger;
        }
    }
}