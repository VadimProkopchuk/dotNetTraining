using DotNetTraining.Lesson8.ORM.DataAccess.Context;
using DotNetTraining.Lesson8.ORM.DataAccess.Contracts;
using DotNetTraining.Lesson8.ORM.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace DotNetTraining.Lesson8.Presentation
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var serviceProvider = ConfigureServices();
            var app = serviceProvider.GetService<Application>();

            await app.CreateAchievementsAsync();

            //Console.ReadLine();

            await app.CreateUsersWithAllAchievementsAsync();

            //Console.ReadLine();

            await app.PrintAllAsync();
        }

        static IServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddTransient<IDataContext, DataContext>();
            serviceCollection.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer("Server=V-PROKOPCHUK\\VPROKOPCHUK;Database=DotNetTraining.Lesson8;User Id=DotNetTraining;Password=!QAZ2wsx12")
                .UseLazyLoadingProxies());
            serviceCollection.AddTransient(typeof(IAppEntityRepository<>), typeof(AppEntityRepository<>));
            serviceCollection.AddTransient<Application>();

            return serviceCollection.BuildServiceProvider();
        }
    }
}
