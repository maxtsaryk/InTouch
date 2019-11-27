using InTouch.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InTouch.Data.Utils
{
    public static class DependancyRegister
    {
        public static IServiceCollection AddDataAccessComponents(
            this IServiceCollection services,
            IConfiguration configuration,
            string connectionStringKey
            )
        {
            services.AddTransient(typeof(IChatUnitOfWork), typeof(ChatUnitOfWork));

            services.AddDbContext<InTouchDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString(connectionStringKey)));

            return services;
        }
    }
}
