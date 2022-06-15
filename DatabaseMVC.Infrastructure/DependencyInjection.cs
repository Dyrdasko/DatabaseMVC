using DatabaseMVC.Domain.Interfaces;
using DatabaseMVC.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMVC.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IContractorRepository, ContractorRepository>();
            services.AddTransient<IDeviceRepository, DeviceRepository>();
            return services;
        }
    }
}
