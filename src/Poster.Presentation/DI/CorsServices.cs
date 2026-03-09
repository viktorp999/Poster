namespace Poster.Presentation.DI
{
    public static class CorsServices
    {
        public const string AllowAllPolicy = "AllowAll";

        public static IServiceCollection AddCorsServices(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(AllowAllPolicy, policy =>
                {
                    policy.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                });
            });

            return services;
        }
    }
}
