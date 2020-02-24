using System;
using System.Collections.Generic;

namespace DotNetTraining.Lesson9.AspApplication.ViewModels
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public List<AchievementViewModel> Achievements { get; set; }
    }
}
