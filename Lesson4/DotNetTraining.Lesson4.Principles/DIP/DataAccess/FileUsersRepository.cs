using System;
using System.Collections.Generic;
using DotNetTraining.Lesson4.Principles.DIP.DataAccessContracts;

namespace DotNetTraining.Lesson4.Principles.DIP.DataAccess
{
    public class FileUsersRepository : IUsersRepository
    {
        public void Add(User entity) => throw new NotImplementedException();

        public List<User> LoadAll() => throw new NotImplementedException();

        public void Remove(User entity) => throw new NotImplementedException();
    }
}
