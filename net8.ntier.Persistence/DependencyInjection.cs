using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using net8.ntier.Persistence.Context;
using net8.ntier.Persistence.Repositories;
using net8.ntier.Persistence.Repositories.IRepositories;
using net8.ntier.Persistence.UoW;

namespace net8.ntier.Persistence
{
    public static class DependencyInjection
    {
        public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            // DbContext registration
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            });

            // Repository generic registration
            services.AddScoped<IAppDbContext, AppDbContext>();
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            //Repository registrations
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
