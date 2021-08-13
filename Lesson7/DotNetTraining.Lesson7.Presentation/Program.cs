using DotNetTraining.Lesson7.PLINQ;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace DotNetTraining.Lesson7.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            // CancellationTokenExample();
            ForAllExample();
        }

        static void CancellationTokenExample()
        {
            var cancelTokenSource = new CancellationTokenSource();
            var token = cancelTokenSource.Token;

            new Task(() =>
            {
                Thread.Sleep(100);
                cancelTokenSource.Cancel();
            }).Start();

            try
            {
                Parallel.ForEach(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 },
                new ParallelOptions { CancellationToken = token },
                x => Console.WriteLine("{0}! = {1}", x, Factorial.ComputeWithSleep(x)));
            }
            catch (OperationCanceledException ex)
            {
                Console.WriteLine("Operation has been canceled.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cancelTokenSource.Dispose();
            }
        }

        static void ForAllExample()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            numbers.AsParallel().ForAll(x => Console.WriteLine("{0}! = {1}", x, Factorial.Compute(x)));
        }
    }
}
