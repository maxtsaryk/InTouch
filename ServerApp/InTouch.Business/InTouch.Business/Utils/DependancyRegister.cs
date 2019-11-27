using InTouch.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InTouch.Business.Utils
{
    public static class DependancyRegister
    {
        public static IServiceCollection AddBusinessComponents(
            this IServiceCollection services,
            IConfiguration configuration,
            string connectionStringKey
            )
        {
            services.AddDataAccessComponents(configuration, connectionStringKey);

            return services;
        }
    }
}
