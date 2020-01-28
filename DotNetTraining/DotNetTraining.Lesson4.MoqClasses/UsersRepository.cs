using System;
using System.Collections.Generic;
using DotNetTraining.Lesson4.MoqClasses.Contracts;

namespace DotNetTraining.Lesson4.MoqClasses
{
    public class UsersRepository : IUsersRepository
    {
        public void Add(User entity) => throw new NotImplementedException();

        public List<User> LoadAll() => throw new NotImplementedException();

        public void Remove(User entity) => throw new NotImplementedException();
    }
}
