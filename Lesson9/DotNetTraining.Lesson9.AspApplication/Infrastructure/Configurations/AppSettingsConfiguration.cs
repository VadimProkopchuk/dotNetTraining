using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetTraining.Lesson9.AspApplication.Infrastructure.Configurations
{
    public static class AppSettingsConfiguration
    {
        public static AppSettings ConfigureAppSettings(this IServiceCollection services, IConfiguration configuration)
        {
            var appSettingsSection = configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);

            return appSettingsSection.Get<AppSettings>();
        }
    }
}
