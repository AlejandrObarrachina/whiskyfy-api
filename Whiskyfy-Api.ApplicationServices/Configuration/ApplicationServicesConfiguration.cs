using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whiskyfy_Api.Domain.Services.Contracts;
using Whiskyfy_Api.Domain.Services.Implementation;
using Whiskyfy_Api.Infrastructure.Repository.Contracts;
using Whiskyfy_Api.Infrastructure.Repository.Implementation;

namespace Whiskyfy_Api.ApplicationServices.Configuration
{
    public static class ApplicationServicesConfiguration
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUsersDomainServices, UsersDomainServices>();
            services.AddScoped<IUserManagmentRepository, UserManagmentRepository>();
            
        }
    }
}
