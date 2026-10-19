using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Poster.Application.Helpers.Options;
using Poster.Application.Helpers.Options.Validators;

namespace Poster.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddSingleton<IValidateOptions<ConnectionStringsOptions>, ConnectionStringsOptionsValidator>();

            return services;
        }
    }
}
