
namespace AspNetSampleWithDI
{
    public interface ISampleMultipleService : ISampleService
    {
    }

    public class SampleOneMultipleService : ISampleMultipleService
    {
        public string SimpleMethod()
        {
            return "SampleOneMultipleServiceAnotherMethod";
        }
    }

    public class SampleTwoMultipleService : ISampleMultipleService
    {
        public string SimpleMethod()
        {
            return "SampleTwoMultipleServiceAnotherMethod";
        }
    }
}