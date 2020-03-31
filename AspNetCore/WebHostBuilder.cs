using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore
{
public class WebHostBuilder
{
    public WebHostBuilder(IHostBuilder hostBuilder, IApplicationBuilder applicationBuilder)
    {
        HostBuilder = hostBuilder;
        ApplicationBuilder = applicationBuilder;
    }

    public IHostBuilder HostBuilder { get; }
    public IApplicationBuilder ApplicationBuilder { get; }
}
}
