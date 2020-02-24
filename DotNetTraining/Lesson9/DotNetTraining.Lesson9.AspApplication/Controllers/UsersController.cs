using System;
using System.Threading.Tasks;
using DotNetTraining.Lesson9.AspApplication.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace DotNetTraining.Lesson9.AspApplication.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsersService usersService;

        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        public async Task<IActionResult> Index()
        {
            var users = await usersService.GetAsync();
            return View(users);
        }

        public async Task<IActionResult> Profile(Guid id)
        {
            var user = await usersService.GetAsync(id);
            return View(user);
        }
    }
}