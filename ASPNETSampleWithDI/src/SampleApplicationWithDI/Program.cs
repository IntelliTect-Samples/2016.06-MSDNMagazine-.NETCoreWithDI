using System;
using System.Threading;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.Logging;
using Microsoft.Framework.Logging.Debug;

namespace SampleApplicationWithDI
{
    class Program
    {
        private static IServiceProvider Provider { get; set; }

        static void Main( string[] args )
        {
            RegisterServices();

            var logger = ActivatorUtilities.GetServiceOrCreateInstance<ILogger>( Provider );

            logger.LogInformation( $"Starting up at: {DateTime.Now}" );

            var time = ActivatorUtilities.GetServiceOrCreateInstance<TimeProvider>( Provider );

            logger.LogInformation( $"TimeProvider reports Now as: {time.Now()}" );

            Thread.Sleep( TimeSpan.FromSeconds( 2 ) );

            logger.LogInformation( "Two seconds have now elapsed." );

            var time2 = ActivatorUtilities.GetServiceOrCreateInstance<TimeProvider>( Provider );

            logger.LogInformation( $"2nd TimeProvider still reports Now as: {time2.Now()}" );

            logger.LogInformation( $"Actual time is: {DateTime.Now}" );
        }

        private static void RegisterServices()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddTransient<ILogger, DebugLogger>( provider => new DebugLogger( typeof(Program).FullName ) );
            services.AddSingleton<TimeProvider>();
            Provider = services.BuildServiceProvider();
        }
    }
}