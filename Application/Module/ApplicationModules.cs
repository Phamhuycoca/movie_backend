using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application.Module
{
    public static class ApplicationModules
    {
        public static IServiceCollection AddApplicationModules(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddMaps(assembly);  
            });
            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);
            return services;
        }
    }
}
