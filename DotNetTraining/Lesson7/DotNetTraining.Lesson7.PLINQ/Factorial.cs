using System.Threading;

namespace DotNetTraining.Lesson7.PLINQ
{
    public static class Factorial
    {
        public static int Compute(int x) => Compute(x, withSleep: false);

        public static int ComputeWithSleep(int x) => Compute(x, withSleep: true);

        private static int Compute(int x, bool withSleep)
        {
            var factorial = 1;

            for (int i = 1; i <= x; i++)
            {
                factorial *= i;
            }

            if (withSleep)
            {
                Thread.Sleep(100 * x);
            }

            return factorial;
        }
    }
}
