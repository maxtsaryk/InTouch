using InTouch.Data.Utils;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InTouch.Business.Utils
{
    public static class DependancyRegister
    {
        public static IServiceCollection AddBusinessComponents(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDataAccessComponents(configuration);

            return services;
        }
    }
}
