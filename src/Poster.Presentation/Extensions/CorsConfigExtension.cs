namespace Poster.Presentation.Extensions
{
    public static class CorsConfigExtension
    {
        public const string PolicyName = "AllowAll";
        public static IServiceCollection AddCorsConfig(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(PolicyName, builder =>
                {
                    builder.WithOrigins("https://localhost:4200")
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowCredentials();
                });
            });

            return services;
        }
    }
}
