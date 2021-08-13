using DotNetTraining.Lesson8.ORM.DataAccess.Contracts;
using DotNetTraining.Lesson8.ORM.Models.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace DotNetTraining.Lesson8.ORM.DataAccess.Context
{
    public class DataContext : IDataContext
    {
        private readonly AppDbContext appDbContext;

        public DataContext(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public Task<int> SaveChangesAsync() => appDbContext.SaveChangesAsync();

        public DbSet<T> Set<T>() where T : class, IAppEntity<Guid> => appDbContext.Set<T>();
    }
}
