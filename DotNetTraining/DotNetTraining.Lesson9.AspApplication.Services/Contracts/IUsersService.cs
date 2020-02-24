using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetTraining.Lesson9.AspApplication.ViewModels;

namespace DotNetTraining.Lesson9.AspApplication.Services.Contracts
{
    public interface IUsersService
    {
        Task<List<UserViewModel>> GetAsync();
    }
}
