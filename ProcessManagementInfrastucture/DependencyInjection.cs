using Microsoft.Extensions.DependencyInjection;
using ProcessManagementApplication.Interfaces;
using ProcessManagementInfrastucture.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessManagementInfrastucture
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfraStructure(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository,UserRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
