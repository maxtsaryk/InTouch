using InTouch.Business.Chat.Interfaces;
using InTouch.Business.Chat.Services;
using InTouch.Data.Chat;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InTouch.Business.Chat.Utils
{
    public static class DependencyRegister
    {
        public static IServiceCollection AddBusinessComponents(
            this IServiceCollection services,
            IConfiguration configuration,
            string connectionStringKey)
        {
            services.AddDataAccessComponents(configuration, connectionStringKey);

            services.AddTransient<IPersonService, PersonService>();
            services.AddTransient<IChatService, ChatService>();

            return services;
        }
    }
}
