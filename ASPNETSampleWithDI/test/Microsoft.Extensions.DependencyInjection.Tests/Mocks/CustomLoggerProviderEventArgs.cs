namespace Microsoft.Extensions.DependencyInjection.Tests.Mocks.CustomLogger
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