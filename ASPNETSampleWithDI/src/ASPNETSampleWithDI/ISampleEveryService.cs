
namespace AspNetSampleWithDI
{
    interface ISampleEveryService :
            ISampleService,
            ISampleMultipleService,
            ISampleScopedService,
            ISampleServiceInstance,
            ISampleSingletonService,
            ISampleOpenGenericService<string>
    {
    }
}
