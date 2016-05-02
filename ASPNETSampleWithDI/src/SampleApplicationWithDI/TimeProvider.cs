
using System;

namespace SampleApplicationWithDI
{
    public class TimeProvider
    {
        public TimeProvider(ILogger logger)
        {
            RightNow = DateTime.Now;
            logger.LogMessage($"TimeProvider created at: {RightNow}");
        }

        private DateTime RightNow { get; set; }

        public DateTime Now()
        {
            return RightNow;
        } 
    }
}