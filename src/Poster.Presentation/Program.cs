using Poster.Presentation.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApiServices(builder.Configuration);
builder.Services.AddIdentityServices(builder.Configuration);
builder.Services.AddCorsServices();

var app = builder.Build();

app.UseCors(CorsServicesExtension.AllowAllPolicy);

app.MapControllers();

app.UseAuthentication();

app.UseAuthorization();

app.Run();
