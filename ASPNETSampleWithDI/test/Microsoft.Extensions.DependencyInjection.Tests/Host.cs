using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection.Tests
{
    public class Host
    {
        public static void Main()
        {
            IServiceCollection serviceCollection = new ServiceCollection();

            Application application = new Application(serviceCollection);

            // Run
            // ...
            application.MakePayment(null);
        }
    }
}
