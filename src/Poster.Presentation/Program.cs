using Poster.Presentation.DI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApiServices(builder.Configuration);
builder.Services.AddIdentityServices(builder.Configuration);
builder.Services.AddCorsServices();

var app = builder.Build();

app.UseExceptionHandler();

app.UseCors(CorsServices.AllowAllPolicy);

app.MapControllers();

app.UseAuthentication();

app.UseAuthorization();

app.Run();
