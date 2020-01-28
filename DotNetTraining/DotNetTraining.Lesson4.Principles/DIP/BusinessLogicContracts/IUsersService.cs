using System.Collections.Generic;

namespace DotNetTraining.Lesson4.Principles.DIP.BusinessLogicContracts
{
    public interface IUsersService
    {
        User CreateUser(string name, string email);
        List<User> GetEmployees();
    }
}
