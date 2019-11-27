using InTouch.Data.Chat;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InTouch.Business.Chat.Utils
{
    public static class DependancyRegister
    {
        public static IServiceCollection AddBusinessComponents(
            this IServiceCollection services,
            IConfiguration configuration,
            string connectionStringKey)
        {
            services.AddDataAccessComponents(configuration, connectionStringKey);

            return services;
        }
    }
}
