using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using net8.ntier.Business.Services.Users;
using net8.ntier.Persistence;

namespace net8.ntier.Business
{
    public static class DependecyInjection
    {
        public static void AddBusinessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserService, UserService>();
            // Orchest persistence services
            services.AddPersistenceServices(configuration);
        }
    }
}
