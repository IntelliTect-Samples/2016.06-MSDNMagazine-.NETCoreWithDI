
using System.Diagnostics;

namespace SampleApplicationWithDI
{
    internal class ConsoleLogger: ILogger
    {
        public void LogMessage( string message )
        {
            Debug.WriteLine( message );
        }
    }
}