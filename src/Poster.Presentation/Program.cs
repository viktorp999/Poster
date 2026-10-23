using Poster.Infrastructure.Data;
using Poster.Infrastructure.Persistance.Database;
using Poster.Presentation.Extensions;
using Scalar.AspNetCore;

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

    app.MapOpenApi();
    app.MapScalarApiReference(options =>
    {
        options
            .WithTitle("Poster Api Documentation")
            .WithTheme(ScalarTheme.None)
            .WithDefaultHttpClient(
                ScalarTarget.CSharp,
                ScalarClient.HttpClient)
            .WithClassicLayout()
            .ForceDarkMode()
            .ShowOperationId()
            .SortTagsAlphabetically()
            .SortOperationsByMethod();
    });
}

app.MapControllers();
app.Run();
