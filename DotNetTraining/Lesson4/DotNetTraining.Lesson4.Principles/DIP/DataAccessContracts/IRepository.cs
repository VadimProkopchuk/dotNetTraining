using System.Collections.Generic;

namespace DotNetTraining.Lesson4.Principles.DIP.DataAccessContracts
{
    public interface IRepository<T> where T : class
    {
        List<T> LoadAll();
        void Add(T entity);
        void Remove(T entity);
    }
}
