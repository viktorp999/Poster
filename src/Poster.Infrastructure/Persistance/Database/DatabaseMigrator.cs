using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Poster.Infrastructure.Persistance.Database
{
    public class DatabaseMigrator
    {
        public static async Task ApplyMigrationsAsync<TDbContext>(IServiceScope scope)
            where TDbContext : DbContext
        {
            TDbContext context = scope.ServiceProvider
                .GetRequiredService<TDbContext>();

            await context.Database.MigrateAsync();
        }
    }
}
