using System;
using DotNetTraining.Lesson6.Delegates;

namespace DotNetTraining.Lesson6.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            


            RunDelegateExample();
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
    }
}
