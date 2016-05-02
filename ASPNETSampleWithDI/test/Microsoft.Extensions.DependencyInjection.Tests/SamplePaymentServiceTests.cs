using Microsoft.Extensions.DependencyInjection.Tests.Mocks;
using Microsoft.Extensions.Logging;
using System;
using Xunit;

namespace Microsoft.Extensions.DependencyInjection.Tests
{
    
    public class SamplePaymentServiceTests
    {
        [Fact]
        public void Create_SamplePaymentServiceWithLoggingSet_Success()
        {
            IServiceCollection serviceCollection = new ServiceCollection();

            ILoggerFactory loggerFactory =
                new LoggerFactory();

            #region Initialize Custom Logging
            CustomLoggerProvider customLoggerProvider;
            loggerFactory.AddCustomLogger(out customLoggerProvider);
            #endregion // Initialize Logging

            serviceCollection.AddInstance<ILoggerFactory>(loggerFactory);

            IServiceProvider serviceProvider =
                serviceCollection.BuildServiceProvider();
            PaymentService paymentService =
                new PaymentService(loggerFactory);

            Assert.StrictEqual<string>(
                "PaymentService created",
                customLoggerProvider.Loggers[typeof(PaymentService).FullName].LogDataQueue.Dequeue());

            serviceCollection.AddSingleton<ILoggerFactory>();
        }
    }
}
