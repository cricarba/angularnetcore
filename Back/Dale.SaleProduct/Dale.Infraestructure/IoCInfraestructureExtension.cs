using System;
using System.Collections.Generic;
using System.Text;
using Dale.Infraestructure.Definitions;
using Dale.Infraestructure.Definitions.Context;
using Dale.Infraestructure.Implementations;
using Dale.Infraestructure.Implementations.Context;
using Microsoft.Extensions.DependencyInjection;

namespace Dale.Infraestructure
{
    public static class IoCInfraestructureExtension
    {
        public static IServiceCollection RegisterInfraestructuraIoC(this IServiceCollection services)
        {
            services.AddTransient<IDaleContext, DaleContext>();
            
            services.AddTransient<IBillDetailRepository, BillDetailRepository>();
            services.AddTransient<IBillRepository, BillRepository>();
            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
      
         
            return services;
        }
    }
}
