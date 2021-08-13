namespace DotNetTraining.Lesson6.Events
{
    public class UserService
    {
        private readonly Dispatcher _dispatcher;

        public UserService(Dispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        public SimpleUser CreateUser(string name)
        {
            var user = new SimpleUser(name);

            _dispatcher.DispatchUserCreatedEvent(user);

            return user;
        }
    }
}
