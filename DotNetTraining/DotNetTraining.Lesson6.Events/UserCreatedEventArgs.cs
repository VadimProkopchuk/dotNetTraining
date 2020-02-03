using System;

namespace DotNetTraining.Lesson6.Events
{
    public class UserCreatedEventArgs : EventArgs
    {
        public UserCreatedEventArgs(SimpleUser simpleUser)
        {
            SimpleUser = simpleUser;
        }

        public SimpleUser SimpleUser { get; }
    }
}
