using System.Collections.Generic;
using DotNetTraining.Lesson9.AspApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DotNetTraining.Lesson9.AspApplication.Components
{
    public class UsersViewListViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke(List<UserViewModel> users)
        {
            return View(users);
        }
    }
}
