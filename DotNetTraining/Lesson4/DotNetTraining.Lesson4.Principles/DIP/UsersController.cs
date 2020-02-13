using System;
using System.Collections.Generic;
using System.Text;
using DotNetTraining.Lesson4.Principles.DIP.BusinessLogicContracts;

namespace DotNetTraining.Lesson4.Principles.DIP
{
    public class UsersController
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        public string GetEmployees()
        {
            var employees = _usersService.GetEmployees();
            return ConvertToPresentationFormat(employees);
        }

        private string ConvertToPresentationFormat(List<User> users)
        {
            throw new NotImplementedException();
        }
    }
}
