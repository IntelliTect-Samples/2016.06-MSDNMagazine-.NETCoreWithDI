
using System;

namespace AspNetSampleWithDI
{
    public class SampleService : ISampleEveryService, IDisposable
    {
        public SampleService()
        {
            Message = Guid.NewGuid().ToString();
        }

        public bool Disposed { get; private set; }

        public string Message { get; set; }

        public string SimpleMethod()
        {
            return Message;
        }

        public void Dispose()
        {
            Disposed = true;
        }
    }
}
