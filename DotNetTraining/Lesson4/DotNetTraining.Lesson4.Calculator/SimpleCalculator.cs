using System;

namespace DotNetTraining.Lesson4.Calculator
{
    public static class SimpleCalculator
    {
        public static int Add(int a, int b) => a + b;

        public static double Sqrt(double a)
        {
            if (a < 0)
            {
                throw new ArgumentException("Argument should be positive");
            }

            return Math.Sqrt(a);
        }

        public static bool IsOdd(int x) => x != 0 && x % 2 != 0;

        public static bool IsEven(int x) => x != 0 && x % 2 == 0;

    }
}
