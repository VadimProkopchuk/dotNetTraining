using System;

namespace DotNetTraining.Lesson6.Events.Clients
{
    public class Logger
    {
        public void LogUser(SimpleUser simpleUser)
        {
            Console.WriteLine("Logger: ID: {0}, Name: {1}", simpleUser.Id, simpleUser.Name);
        }
    }
}
