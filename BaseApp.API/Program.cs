using BaseApp.Application;
using BaseApp.Infrastructure;
using BaseApp.API;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureApplicationServices();
builder.Services.ConfigureInfrastructureServices(builder.Configuration);
builder.Services.ConfigureApiServices(builder.Configuration);

var app = builder.Build();

// Use centralized exception handler middleware
app.ConfigureExceptionHandler();

app.MapControllers();

app.Run();

// Make Program class public for testing if needed
public partial class Program { }
