// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

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