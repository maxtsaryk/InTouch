using InTouch.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InTouch.Business
{
    public static class DependancyRegistrator
    {
        public static IServiceCollection AddBusinessComponents(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDataAccessComponents(configuration);

            return services;
        }
    }
}
