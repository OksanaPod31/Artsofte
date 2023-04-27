using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeApplication.Application.Interfaces;

namespace EmployeeApplication.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];
            services.AddDbContext<EmployeeApplicationDbContext>(options => { options.UseSqlServer(connectionString, b => b.MigrationsAssembly("EmployeeApplication.WebApi")); });
            services.AddScoped<IEmployeeApplicationDbContext>(provider => provider.GetService<EmployeeApplicationDbContext>());
            return services;
        }
    }
}
