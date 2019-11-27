using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InTouch.Data
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

            services.AddDbContext<ChatDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString(connectionStringKey)));

            return services;
        }
    }
}
