using System;
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
        private readonly IDataContext dataContext;

        public UsersService(IAppEntityRepository<User> usersRepository,
            IDataContext dataContext)
        {
            this.usersRepository = usersRepository;
            this.dataContext = dataContext;
        }

        public async Task<List<UserViewModel>> GetAsync()
        {
            var users = await usersRepository
                .GetQuery()
                .ToListAsync();

            return users
                .Select(MapUser)
                .ToList();
        }

        public async Task<List<UserViewModel>> SearchAsync(string name)
        {
            var users = await usersRepository
                .GetQuery()
                .Where(x => x.FirstName.Contains(name) || x.LastName.Contains(name))
                .ToListAsync();

            return users
                .Select(MapUser)
                .ToList();
        }

        public async Task<UserViewModel> GetAsync(Guid id)
        {
            var user = await usersRepository
                .GetQuery()
                .FirstOrDefaultAsync(x => x.Id == id);

            return MapUser(user);
        }

        public async Task<bool> HasAnyWithAsync(string firstName, string lastName)
        {
            return await usersRepository
                .GetQuery()
                .AnyAsync(x => x.FirstName == firstName && x.LastName == lastName);
        }

        public async Task<UserViewModel> CreateAsync(CreateUserViewModel createUserViewModel)
        {
            var user = new User()
            {
                FirstName = createUserViewModel.FirstName,
                LastName = createUserViewModel.LastName
            };

            usersRepository.Add(user);

            await dataContext.SaveChangesAsync();

            return MapUser(user);
        }

        private UserViewModel MapUser(User user)
        {
            return new UserViewModel()
            {
                Id = user.Id,
                FullName = $"{user.FirstName} {user.LastName}",
                Achievements = user.UserAchievements?.Select(a => new AchievementViewModel
                {
                    ReceivedAt = a.CreatedAt,
                    Name = a.Achievement.Name
                }).ToList()
            };
        }
    }
}