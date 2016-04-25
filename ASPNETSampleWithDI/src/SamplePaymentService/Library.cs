using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleLibrary
{
    internal static class Library
    {
        static public IServiceCollection ServiceCollection { get; set; }
    }
}
