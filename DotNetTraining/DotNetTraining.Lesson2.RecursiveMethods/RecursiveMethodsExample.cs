using System;

namespace DotNetTraining.Lesson2.RecursiveMethods
{
    public static class RecursiveMethodsExample
    {
        public static long ComputeFactorial(this int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Argument should be positive.", nameof(n));
            }
            
            return n >= 1 ? n * ComputeFactorial(n - 1) : 1;
        }
    }
}
