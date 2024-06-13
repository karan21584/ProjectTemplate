
using ProjectTemplate.Application.Interface.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ProjectTemplate.Application.Services.Configuration
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection service, ConfigurationManager configuration)
        {
            
            service.AddTransient<IRoleService, RoleService>();
            return service;
        }
    }
}
