using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleLibrary
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
public class PaymentService
{
    public ILogger Logger { get; }

    public PaymentService(IServiceProvider serviceProvider)
    {
        Library.ServiceProvider = serviceProvider;

        Logger = serviceProvider.GetService<ILoggerFactory>()?.CreateLogger<PaymentService>();
        if(Logger == null)
        {
            throw new ArgumentException(
                $"The service provider has not been initialized with an ILoggingFactory.  Invoke IServiceCollection.AddInstance<ILoggerFactor>(...) before instantiating { nameof(PaymentService) }", nameof(serviceProvider));
        }
    }
}
}
