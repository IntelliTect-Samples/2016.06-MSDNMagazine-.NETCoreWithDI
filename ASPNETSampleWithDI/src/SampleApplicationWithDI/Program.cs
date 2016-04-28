using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Framework.DependencyInjection;

namespace SampleApplicationWithDI
{
    class Program
    {
        private static IServiceProvider Provider { get; set; }

        static void Main( string[] args )
        {
            Bootstrap();

            var logger = ActivatorUtilities.GetServiceOrCreateInstance<ILogger>( Provider );

            logger.LogMessage( $"Starting up at: {DateTime.Now}" );

            var time = ActivatorUtilities.GetServiceOrCreateInstance<TimeProvider>( Provider );

            logger.LogMessage( $"Time provider reports Now as: {time.Now()}" );

            Thread.Sleep(TimeSpan.FromSeconds( 2 ));

            var time2 = ActivatorUtilities.GetServiceOrCreateInstance<TimeProvider>(Provider);

            logger.LogMessage($"2nd Time provider still reports Now as: {time2.Now()}");

            logger.LogMessage($"Actual time is: {DateTime.Now}");

        }

        private static void Bootstrap()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddTransient<ILogger, ConsoleLogger>();
            services.AddSingleton<TimeProvider>();
            Provider = services.BuildServiceProvider();
        }
    }
}