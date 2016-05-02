using System;
using Microsoft.Extensions.Logging;

namespace Microsoft.Extensions.DependencyInjection.Tests.Mocks
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
public class MockPaymentService: IPaymentService
{
    public ILogger Logger { get; }

    public MockPaymentService(ILoggerFactory loggerFactory)
    {

        Logger = loggerFactory?.CreateLogger<MockPaymentService>();
        if(Logger == null)
        {
            throw new ArgumentNullException(nameof(loggerFactory));
        }
        
        Logger.LogInformation("MockPaymentService created");
    }
}
}
