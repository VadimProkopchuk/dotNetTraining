using DotNetTraining.Lesson8.ORM.Models.Contracts;
using System;
using System.Linq;

namespace DotNetTraining.Lesson8.ORM.DataAccess.Contracts
{
    public interface IAppEntityRepository<T> where T : IAppEntity<Guid>
    {
        IQueryable<T> GetQuery();
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        void Remove(Guid id);
    }
}
