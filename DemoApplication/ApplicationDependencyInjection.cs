using Demo.Application.Service;
using Demo.Application.Service.Implemnet;
using Demo.DataAccess.Repositories;
using Demo.DataAccess.Repositories.Implement;
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
            services.AddScoped<IRoomService, RoomService>();
            services.AddScoped<IExamService, ExamService>();
            services.AddScoped<IEmployeeService, EmployeeService>();

        }

        private static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(PersonMappingProfile));
        }
    }
}
