using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using BaseApp.Application.Persistence;
using BaseApp.Infrastructure.Persistance;

namespace BaseApp.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITodoRepository, TodoRepository>();

            // TODO: Add DbContext, Authentication, etc.

            return services;
        }
    }
}
