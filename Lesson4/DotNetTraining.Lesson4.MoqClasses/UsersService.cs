using System.Collections.Generic;
using System.Linq;
using DotNetTraining.Lesson4.MoqClasses.Contracts;

namespace DotNetTraining.Lesson4.MoqClasses
{
    public class UsersService
    {
        private readonly IUsersRepository _usersRepository;

        public UsersService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public User CreateUser(string name, string email)
        {
            var user = new User()
            {
                Name = name,
                Email = email,
                IsEmployee = email.Contains("ocsico.com"),
            };

            _usersRepository.Add(user);
            return user;
        }

        public List<User> GetEmployees()
        {
            return _usersRepository
                .LoadAll()
                .Where(x => x.IsEmployee)
                .ToList();
        }
    }
}
