using Poster.Infrastructure.Data;
using Poster.Infrastructure.Data.SeedData.DataSeeders;
using Poster.Infrastructure.Data.SeedData.DataSeeders.Common;
using Poster.Infrastructure.Persistance.Database;
using Poster.Presentation.Extensions;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApiServices();
builder.Services.AddIdentityServices();
builder.Services.AddApiVersioningConfig();
builder.Services.AddCorsConfig();

var app = builder.Build();

app.UseExceptionHandler();

if (app.Environment.IsDevelopment())
{
    try
    {
        using var scope = app.Services.CreateScope();
        var services = scope.ServiceProvider;
        var dbContext = services.GetRequiredService<PosterDbContext>();

        await DatabaseMigrator.ApplyMigrationsAsync<PosterDbContext>(scope);
        await IdentitySeeder.SeedIdentityAsync(services);
        await DataSeeder.SeedDataAsync(dbContext);
    }
    catch (Exception ex)
    {
        app.Logger.LogError(ex, "An error occurred while applying migrations.");

        throw;
    }

    var versions = app.DescribeApiVersions();

    app.MapOpenApi()
        .WithDocumentPerVersion();

    app.MapScalarApiReference(options =>
    {
        options
            .WithTheme(ScalarTheme.None)
            .WithDefaultHttpClient(
                ScalarTarget.CSharp,
                ScalarClient.HttpClient)
            .WithClassicLayout()
            .ForceDarkMode()
            .ShowOperationId()
            .SortTagsAlphabetically()
            .SortOperationsByMethod();

        for (var i = 0; i < versions.Count; i++)
        {
            var version = versions[i];

            options.WithTitle($"Poster Api {version.ApiVersion}")
            .WithOpenApiRoutePattern($"/openapi/{version}.json");

            options.AddDocument(
                version.GroupName!,
                version.GroupName!,
                isDefault: i == versions.Count - 1);
        }
    });
}

app.UseRouting();
app.UseCors(CorsConfigExtension.PolicyName);
app.MapControllers();
app.Run();
