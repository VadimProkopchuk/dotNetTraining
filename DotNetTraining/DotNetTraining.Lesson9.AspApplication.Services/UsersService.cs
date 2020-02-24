using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetTraining.Lesson8.ORM.DataAccess.Contracts;
using DotNetTraining.Lesson8.ORM.Models;
using DotNetTraining.Lesson9.AspApplication.Services.Contracts;
using DotNetTraining.Lesson9.AspApplication.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace DotNetTraining.Lesson9.AspApplication.Services
{
    public class UsersService : IUsersService
    {
        private readonly IAppEntityRepository<User> usersRepository;

        public UsersService(IAppEntityRepository<User> usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        public async Task<List<UserViewModel>> GetAsync()
        {
            var users = await usersRepository
                .GetQuery()
                .ToListAsync();

            return users
                .Select(x => new UserViewModel
                {
                    Id = x.Id,
                    FullName = $"{x.FirstName} {x.LastName}",
                    Achievements = x.UserAchievements.Select(a => new AchievementViewModel
                    {
                        ReceivedAt = a.CreatedAt,
                        Name = a.Achievement.Name
                    }).ToList()
                })
                .ToList();
        }
    }
}