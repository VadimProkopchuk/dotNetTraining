using DotNetTraining.Lesson8.ORM.Models.Contracts;
using System;
using System.Collections.Generic;

namespace DotNetTraining.Lesson8.ORM.Models
{
    public class User : IAppEntity<Guid>
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<UserAchievement> UserAchievements { get; set; }
    }
}
