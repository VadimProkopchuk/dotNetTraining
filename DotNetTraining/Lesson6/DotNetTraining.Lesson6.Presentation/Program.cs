using System;
using System.Linq;
using DotNetTraining.Lesson6.Delegates;
using DotNetTraining.Lesson6.Events;
using DotNetTraining.Lesson6.Events.Clients;
using DotNetTraining.Lesson6.LINQ.Generators;

namespace DotNetTraining.Lesson6.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            // RunDelegateExample();
            // RunEventsExample();
            // LinqGeneratorExamples();
            // DeferredExecutionExample();
            ImmediateQueryExecution();

            Console.WriteLine("Method executed.");
        }


        static void RunDelegateExample()
        {
            var user = new User("Vadim");

            user.PrintInfo(Console.WriteLine);
            user.PrintInfo(delegate(string info) { Console.WriteLine("Anonymous function. {0}", info); });
            user.PrintInfo(info => Console.WriteLine("Anonymous function. {0}", info));

            
            Console.WriteLine("========");
            
            Print print = Console.WriteLine;
            print += info => Console.WriteLine("2. {0}", info);
            print += info => Console.WriteLine("3. {0}", info);

            user.PrintInfo(print);
        }

        static void RunEventsExample()
        {
            var dispatcher = new Dispatcher();
            var logger = new Logger();
            var httpClient = new HttpUserClient();

            dispatcher.OnUserCreated += (sender, args) => logger.LogUser(args.SimpleUser);
            dispatcher.OnUserCreated += (sender, args) => httpClient.SendUserInfo(args.SimpleUser);

            var service = new UserService(dispatcher);
            var user = service.CreateUser("Vadim");

        }

        static void LinqGeneratorExamples()
        {
            foreach (var number in FibonacciGenerator.Generate(10))
            {
                Console.WriteLine(number);
            }
        }

        static void DeferredExecutionExample()
        {
            var fibonacciNumbers = FibonacciGenerator.Generate().Take(5);
        }

        static void ImmediateQueryExecution()
        {
            var firstFibonacciNumber = FibonacciGenerator.Generate().First();
        }
    }
}
