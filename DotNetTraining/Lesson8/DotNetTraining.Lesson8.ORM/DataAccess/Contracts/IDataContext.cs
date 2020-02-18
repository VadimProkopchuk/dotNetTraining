using DotNetTraining.Lesson8.ORM.Models.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace DotNetTraining.Lesson8.ORM.DataAccess.Contracts
{
    public interface IDataContext
    {
        DbSet<T> Set<T>() where T : class, IAppEntity<Guid>;
        Task<int> SaveChangesAsync();
    }
}
