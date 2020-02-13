using System;

namespace DotNetTraining.Lesson6.Events
{
    public class SimpleUser
    {
        public SimpleUser(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        public Guid Id { get; }
        public string Name { get; }
    }
}
