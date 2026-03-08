using Microsoft.Extensions.DependencyInjection;

namespace Poster.Application.DI
{
    public static class ApplicationDependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services;
        }
    }
}
