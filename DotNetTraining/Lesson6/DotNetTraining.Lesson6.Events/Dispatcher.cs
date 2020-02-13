using System;

namespace DotNetTraining.Lesson6.Events
{
    public class Dispatcher
    {
        public event EventHandler<UserCreatedEventArgs> OnUserCreated;

        public void DispatchUserCreatedEvent(SimpleUser simpleUser)
        {
            OnUserCreated?.Invoke(this, new UserCreatedEventArgs(simpleUser));
        }
    }
}
