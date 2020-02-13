using System;

namespace DotNetTraining.Lesson6.Events.Clients
{
    public class HttpUserClient
    {
        public void SendUserInfo(SimpleUser simpleUser)
        {
            // ....

            Console.WriteLine("HTTP Client: {0}", simpleUser.Id);
        }
    }
}
