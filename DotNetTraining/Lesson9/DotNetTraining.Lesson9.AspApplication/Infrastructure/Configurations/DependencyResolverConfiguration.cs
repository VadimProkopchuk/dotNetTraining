using DotNetTraining.Lesson8.ORM.DataAccess.Contracts;
using DotNetTraining.Lesson8.ORM.DataAccess.Repositories;
using DotNetTraining.Lesson9.AspApplication.Services;
using DotNetTraining.Lesson9.AspApplication.Services.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetTraining.Lesson9.AspApplication.Infrastructure.Configurations
{
    public static class DependencyResolverConfiguration
    {
        public static void ConfigureDependencies(this IServiceCollection services)
        {
            services.AddTransient(typeof(IAppEntityRepository<>), typeof(AppEntityRepository<>));
            services.AddTransient<IUsersService, UsersService>();
        }
    }
}
