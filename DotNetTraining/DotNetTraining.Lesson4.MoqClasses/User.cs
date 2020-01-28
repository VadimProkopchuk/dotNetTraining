using System;

namespace DotNetTraining.Lesson4.MoqClasses
{
    public class User
    {
        public User()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsEmployee { get; set; }
    }
}
