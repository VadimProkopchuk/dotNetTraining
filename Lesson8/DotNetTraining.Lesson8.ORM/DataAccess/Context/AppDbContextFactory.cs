using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DotNetTraining.Lesson8.ORM.DataAccess.Context
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Server=V-PROKOPCHUK\\VPROKOPCHUK;Database=DotNetTraining.Lesson8;User Id=DotNetTraining;Password=!QAZ2wsx12");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
