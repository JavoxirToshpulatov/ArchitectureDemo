using DemoDataAccess.Repositories;
using DemoDataAccess.Repositories.Implement;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using N_Tier.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DemoDataAccess
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDatabase(configuration);
            services.AddRepository(Assembly.GetExecutingAssembly());
            return services;
        }

        private static void AddRepository (this IServiceCollection services, Assembly assembly)
        {
            var repositoryTypes = assembly.GetTypes()
           .Where(type => type.IsClass && !type.IsAbstract && type.GetInterfaces().Any(i => i.Name.EndsWith("Repository")))
           .ToList();

            foreach (var repositoryType in repositoryTypes)
            {
                // Find the specific interface implemented by this repository
                var specificInterface = repositoryType.GetInterfaces()
                    .FirstOrDefault(i => i.Name.EndsWith("Repository") && i != typeof(IBaseRepository<>));

                if (specificInterface != null)
                {
                    // Register the specific interface with the repository type
                    Console.WriteLine($"Registering {repositoryType.Name} as {specificInterface.Name}");
                    services.AddScoped(specificInterface, repositoryType);
                }
            }
            //services.AddScoped<IPersonRepository, PersonRepository>();
        }

        private static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<DatabaseContext>(options =>
                options.UseNpgsql(connectionString));
        }
        
    }
}
