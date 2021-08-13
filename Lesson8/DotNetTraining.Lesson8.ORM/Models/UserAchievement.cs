using DotNetTraining.Lesson8.ORM.Models.Contracts;
using System;

namespace DotNetTraining.Lesson8.ORM.Models
{
    public class UserAchievement : IAppEntity<Guid>
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid AchievementId { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual User User { get; set; }
        public virtual Achievement Achievement { get; set; }
    }
}
