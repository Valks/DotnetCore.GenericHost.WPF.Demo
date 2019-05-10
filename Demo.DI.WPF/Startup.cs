using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Demo.DI.WPF
{
    public class Startup
    {
        public void ConfigureServices(HostBuilderContext hostContext, IServiceCollection services)
        {
            services.AddSingleton<Services.CounterService>();

            // Register Windows manually
            services.AddSingleton<MainWindow>();
        }
    }
}
