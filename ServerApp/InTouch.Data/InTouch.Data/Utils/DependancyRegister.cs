using InTouch.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InTouch.Data.Utils
{
    public static class DependancyRegister
    {
        public static IServiceCollection AddDataAccessComponents(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<InTouchDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<IChatUnitOfWork, ChatUnitOfWork>();

            return services;
        }
    }
}
