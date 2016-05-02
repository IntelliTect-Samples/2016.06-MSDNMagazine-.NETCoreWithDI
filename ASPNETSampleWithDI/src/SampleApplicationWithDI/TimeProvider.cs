using System;
using Microsoft.Framework.Logging;

namespace SampleApplicationWithDI
{
    public class TimeProvider
    {
        public TimeProvider( ILogger logger )
        {
            RightNow = DateTime.Now;
            logger.LogInformation( $"TimeProvider created at: {RightNow}" );
        }

        public string[] SomeStrings { get; set; }

        private DateTime RightNow { get; }

        public DateTime Now()
        {
            return RightNow;
        }
    }
}