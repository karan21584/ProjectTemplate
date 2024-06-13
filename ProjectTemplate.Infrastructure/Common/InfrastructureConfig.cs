using ProjectTemplate.Application.Interface.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ProjectTemplate.Infrastructure.Common
{
    public static class InfrastructureConfig
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection service, ConfigurationManager configuration)
        {
            service.AddDbContext<AppDbContext>(Options =>

                        Options.UseNpgsql(configuration.GetConnectionString("DataBase")).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));

            service.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            service.AddTransient<IRoleRepository, RoleRepository>();
            return service;
        }
    }
}
