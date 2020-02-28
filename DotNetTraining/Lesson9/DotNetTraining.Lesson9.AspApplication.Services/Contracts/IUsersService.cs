using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetTraining.Lesson9.AspApplication.ViewModels;

namespace DotNetTraining.Lesson9.AspApplication.Services.Contracts
{
    public interface IUsersService
    {
        Task<List<UserViewModel>> GetAsync();
        Task<List<UserViewModel>> SearchAsync(string name);
        Task<UserViewModel> GetAsync(Guid id);
        Task<UserViewModel> CreateAsync(CreateUserViewModel createUserViewModel);
        Task<bool> HasAnyWithAsync(string firstName, string lastName);
    }
}
