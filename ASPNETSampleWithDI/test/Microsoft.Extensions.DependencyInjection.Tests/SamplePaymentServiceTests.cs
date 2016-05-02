using Microsoft.Extensions.DependencyInjection.Tests.Mocks.CustomLogger;
using Microsoft.Extensions.Logging;
using SamplePaymentService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
                new Logging.LoggerFactory();
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
                customLoggerProvider.Loggers[nameof(PaymentService)].LogDataQueue.Dequeue());

            serviceCollection.AddSingleton<ILoggerFactory>();
        }
    }
}
