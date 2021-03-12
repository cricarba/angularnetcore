using System;
using System.Collections.Generic;
using System.Text;
using Dale.ApplicationServices.Definitions;
using Dale.ApplicationServices.Implementations;
using Dale.Infraestructure;
using Microsoft.Extensions.DependencyInjection;

namespace Dale.ApplicationServices
{
    public static class IoCApplicationServiceExtension
    {
        public static IServiceCollection RegisterApplicationServicesIoC(this IServiceCollection services)
        {
            services.AddTransient<IBillService, BillService>();
            services.AddTransient<IClientService, ClientService>();
            services.AddTransient<IProductService, ProductService>();
            services.RegisterInfraestructuraIoC();
            return services;
        }
    }
}
