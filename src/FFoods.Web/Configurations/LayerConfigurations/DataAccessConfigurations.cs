using FFoods.DataAccess.DbContexts;
using FFoods.DataAccess.Interfaces;
using FFoods.DataAccess.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace FFoods.Web.Configurations.LayerConfigurations
{
    public static class DataAccessConfigurations
    {
        public static void AddDataAccess(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("DatabaseConnection")!;
            services.AddDbContext<AppDbContext>(options=>options.UseNpgsql(connectionString));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
