using DotNetTraining.Lesson8.ORM.DataAccess.Contracts;
using DotNetTraining.Lesson8.ORM.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetTraining.Lesson8.Presentation
{
    class Application
    {
        private readonly IDataContext dataContext;
        private readonly IAppEntityRepository<Achievement> achievementRepository;
        private readonly IAppEntityRepository<User> usersRepository;
        private readonly IAppEntityRepository<UserAchievement> userAchievementRepository;

        public Application(IDataContext dataContext,
            IAppEntityRepository<Achievement> achievementRepository,
            IAppEntityRepository<User> usersRepository,
            IAppEntityRepository<UserAchievement> userAchievementRepository)
        {
            this.dataContext = dataContext;
            this.achievementRepository = achievementRepository;
            this.usersRepository = usersRepository;
            this.userAchievementRepository = userAchievementRepository;
        }

        public async Task CreateAchievementsAsync()
        {
            var data = new List<Achievement>()
            {
                new Achievement() { Name = "C# - Bronze" },
                new Achievement() { Name = "C# - Silver" },
                new Achievement() { Name = "C# - Gold" },
            };

            foreach (var achievement in data)
            {
                achievementRepository.Add(achievement);
            }

            await dataContext.SaveChangesAsync();
        }

        public async Task CreateUsersWithAllAchievementsAsync()
        {
            var user = new User() { FirstName = "Vadim", LastName = "Prokopchuk" };
            var newUser = new User() { FirstName = "New", LastName = "User" };

            usersRepository.Add(user);
            usersRepository.Add(newUser);

            await dataContext.SaveChangesAsync();

            var achievements = await achievementRepository.GetQuery().ToListAsync();
            foreach (var achievement in achievements)
            {
                var userAchievement = new UserAchievement()
                {
                    CreatedAt = DateTime.Now,
                    UserId = user.Id,
                    AchievementId = achievement.Id
                };
                userAchievementRepository.Add(userAchievement);
            }

            await dataContext.SaveChangesAsync();
        }

        public async Task PrintAllAsync()
        {
            foreach (var user in await usersRepository.GetQuery().ToListAsync())
            {
                Console.WriteLine("User: ");
                Console.WriteLine("   Id: {0}", user.Id);
                Console.WriteLine("   Full Name: {0} {1}", user.FirstName, user.LastName);
                Console.WriteLine("   Achievements: ");

                foreach (var userAchievement in user.UserAchievements)
                {
                    Console.WriteLine("   - Achievement: {0} ({1})", userAchievement.Achievement.Name, userAchievement.CreatedAt);
                }
 
                Console.WriteLine();
            }
        }
    }
}
