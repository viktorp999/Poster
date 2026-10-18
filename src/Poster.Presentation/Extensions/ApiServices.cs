using Poster.Application;
using Poster.Infrastructure;

namespace Poster.Presentation.Extensions
{
    public static class ApiServices
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services)
        {
            services.AddApplication();
            services.AddInfrastructure();

            return services;
        }
    }
}
