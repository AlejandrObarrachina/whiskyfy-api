
using Microsoft.AspNetCore.Mvc.Versioning;
using Whiskyfy_Api.ApplicationServices.Configuration;
using Whiskyfy_Api.ApplicationServices.Contracts;
using Whiskyfy_Api.ApplicationServices.Implementation;
using Whiskyfy_Api.Controllers;
using Whiskyfy_Api.Domain.Services.Contracts;
using Whiskyfy_Api.Domain.Services.Implementation;
using Whiskyfy_Api.Infrastructure.Repository.Contracts;
using Whiskyfy_Api.Infrastructure.Repository.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddHttpContextAccessor();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUserManagmentAppServices, UserManagmentAppServices>();
builder.Services.AddScoped<IProductsApplicationServices, ProductsApplicationServices>();

builder.Services.AddApiVersioning(o =>
{
    o.AssumeDefaultVersionWhenUnspecified = true;
    o.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
    o.ReportApiVersions = true;
    o.ApiVersionReader = ApiVersionReader.Combine(
        new QueryStringApiVersionReader("api-version"),
        new HeaderApiVersionReader("X-Version"),
        new MediaTypeApiVersionReader("ver"));
});
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddHttpContextAccessor();

//Configurations
IConfiguration configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

ApplicationServicesConfiguration.ConfigureServices(builder.Services, configuration);

builder.Services.AddMemoryCache();
builder.Services.AddHttpClient();

var app = builder.Build();







// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Use((context, next) =>
{
    context.Response.Headers.Remove("Server");
    context.Response.Headers.Remove("X-Powered-By");
    return next();
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
