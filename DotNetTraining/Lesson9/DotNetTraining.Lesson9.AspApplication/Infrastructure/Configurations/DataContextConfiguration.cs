using DotNetTraining.Lesson8.ORM.DataAccess.Context;
using DotNetTraining.Lesson8.ORM.DataAccess.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetTraining.Lesson9.AspApplication.Infrastructure.Configurations
{
    public static class DataContextConfiguration
    {
        public static void ConfigureDataContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IDataContext, DataContext>();
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"])
                    .UseLazyLoadingProxies());
        }
    }
}
