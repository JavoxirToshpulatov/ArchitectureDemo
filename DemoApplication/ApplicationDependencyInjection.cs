using DemoApplication.MappingProfile;
using DemoApplication.Service;
using DemoApplication.Service.Implemnet;
using Microsoft.Extensions.DependencyInjection;

namespace Demo.Application
{
    public static class ApplicationDependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddServices();

            services.RegisterAutoMapper();

            return services;
        }

        private static void AddServices(this IServiceCollection services)
        {

            services.AddScoped<IPersonService, PersonService>();

        }

        private static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(PersonMappingProfile));
        }
    }
}
