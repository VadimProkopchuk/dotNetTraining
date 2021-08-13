using DotNetTraining.Lesson8.ORM.Models.Contracts;
using System;
using System.Collections.Generic;

namespace DotNetTraining.Lesson8.ORM.Models
{
    public class Achievement : IAppEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<UserAchievement> UserAchievements { get; set; }
    }
}
