using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection.Tests
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
public class PaymentService: IPaymentService
{
    public ILogger Logger { get; }

    public PaymentService(ILoggerFactory loggerFactory)
    {

        Logger = loggerFactory?.CreateLogger<PaymentService>();
        if(Logger == null)
        {
            throw new ArgumentNullException(nameof(loggerFactory));
        }
        
        Logger.LogInformation("PaymentService created");
    }
}
}
