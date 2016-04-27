using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection.Tests.Mocks.CustomLogger
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
