using System;
using System.Threading.Tasks;
using DotNetTraining.Lesson9.AspApplication.Services.Contracts;
using DotNetTraining.Lesson9.AspApplication.ViewModels;
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

        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateUser(CreateUserViewModel user)
        {
            var hasExistUser = await usersService.HasAnyWithAsync(user.FirstName, user.LastName);

            if (hasExistUser)
            {
                ModelState.AddModelError(String.Empty, $"User {user.FirstName} {user.LastName} already exist.");
            }
            
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            
            await usersService.CreateAsync(user);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> UserSearch(string name)
        {
            var users = await usersService.SearchAsync(name);

            return PartialView("_UsersSearch", users);
        }
    }
}