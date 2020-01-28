using System;
using System.Collections.Generic;
using System.Linq;
using DotNetTraining.Lesson4.MoqClasses;
using DotNetTraining.Lesson4.MoqClasses.Contracts;
using Moq;
using NUnit.Framework;

namespace DotNetTraining.Lesson4.Tests.ServiceTests
{
    [TestFixture]
    class UsersServiceTests
    {
        private IUsersRepository _usersRepository;


        [SetUp]
        public void Setup()
        {
            var fakeUsers = new List<User>();
            var moqUsersRepository = new Mock<IUsersRepository>();

            moqUsersRepository.Setup(x => x.Add(It.IsAny<User>())).Callback((User user) => fakeUsers.Add(user));
            moqUsersRepository.Setup(x => x.LoadAll()).Returns(fakeUsers);
            moqUsersRepository.Setup(x => x.Remove(It.IsAny<User>())).Callback((User user) =>
                fakeUsers.Remove(fakeUsers.Find(x => x.Id == user.Id)));

            _usersRepository = moqUsersRepository.Object;
        }

        [Test]
        public void GetEmployees_ReturnOneUser()
        {
            var usersService = new UsersService(_usersRepository);

            var employee = usersService.CreateUser("Vadim", "vadim.prokopchuk@ocsico.com");
            usersService.CreateUser("Bob", "bob@domain.local");
            usersService.CreateUser("Alice", "alice@domain.local");

            var actualEmployees = usersService.GetEmployees();
            var expectedEmployees = 1;

            Assert.AreEqual(expectedEmployees, actualEmployees.Count, Double.Epsilon, "Should be one employee.");
            Assert.AreEqual(employee, actualEmployees.First(), "Employee should be contain 'ocsico.com' in email address");
        }

    }
}
