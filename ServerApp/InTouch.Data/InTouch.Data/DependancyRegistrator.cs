using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InTouch.Data
{
    public static class DependancyRegistrator
    {
        public static IServiceCollection AddDataAccessComponents(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<InTouchDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}
