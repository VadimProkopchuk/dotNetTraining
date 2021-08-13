using DotNetTraining.Lesson8.ORM.DataAccess.Contracts;
using DotNetTraining.Lesson8.ORM.Models.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace DotNetTraining.Lesson8.ORM.DataAccess.Repositories
{
    public class AppEntityRepository<T> : IAppEntityRepository<T> where T : class, IAppEntity<Guid>
    {
        public AppEntityRepository(IDataContext dataContext)
        {
            EntitiesSet = dataContext.Set<T>();
        }

        protected DbSet<T> EntitiesSet { get; private set; }

        public void Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            EntitiesSet.Attach(entity);
            EntitiesSet.Add(entity);
        }

        public IQueryable<T> GetQuery() => EntitiesSet;

        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            EntitiesSet.Attach(entity);
            EntitiesSet.Remove(entity);
        }

        public void Remove(Guid id)
        {
            var entity = EntitiesSet.FirstOrDefault(x => x.Id == id);
            Remove(entity);
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            EntitiesSet.Attach(entity);
            EntitiesSet.Update(entity);
        }
    }
}
