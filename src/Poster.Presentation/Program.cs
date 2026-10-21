using Poster.Infrastructure.Data;
using Poster.Infrastructure.Persistance.Database;
using Poster.Presentation.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApiServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    try
    {
        using IServiceScope scope = app.Services.CreateScope();

        DatabaseMigrator.ApplyMigrations<PosterDbContext>(scope);
    }
    catch (Exception ex)
    {
        app.Logger.LogError(ex, "An error occurred while applying migrations.");

        throw;
    }
}

app.Run();
