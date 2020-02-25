using System;
using System.Threading.Tasks;
using DotNetTraining.Lesson9.AspApplication.Services.Contracts;
using DotNetTraining.Lesson9.AspApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DotNetTraining.Lesson9.AspApplication.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersApiController : ControllerBase
    {
        private readonly IUsersService usersService;

        public UsersApiController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await usersService.GetAsync();
            return Ok(users);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var user = await usersService.GetAsync(id);
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateUserViewModel model)
        {
            var user = await usersService.CreateAsync(model);
            return Ok(user);
        }
    }
}