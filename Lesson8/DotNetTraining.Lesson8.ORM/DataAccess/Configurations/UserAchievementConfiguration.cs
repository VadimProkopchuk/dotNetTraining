using DotNetTraining.Lesson8.ORM.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetTraining.Lesson8.ORM.DataAccess.Configurations
{
    public class UserAchievementConfiguration : IEntityTypeConfiguration<UserAchievement>
    {
        public void Configure(EntityTypeBuilder<UserAchievement> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();
            builder.Property(x => x.CreatedAt)
                .IsRequired();

            builder.HasOne(x => x.User)
                .WithMany(x => x.UserAchievements)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Achievement)
                .WithMany(x => x.UserAchievements)
                .HasForeignKey(x => x.AchievementId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("UserAchievements");
        }
    }
}
