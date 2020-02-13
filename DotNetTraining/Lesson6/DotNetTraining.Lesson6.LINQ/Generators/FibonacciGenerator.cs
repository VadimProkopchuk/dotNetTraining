using System;
using System.Collections.Generic;

namespace DotNetTraining.Lesson6.LINQ.Generators
{
    public static class FibonacciGenerator
    {
        public static IEnumerable<int> Generate()
        {
            Console.WriteLine("FibonacciGenerator says that the method Generate was called.");
            
            var a = 0;
            var b = 1;
            
            yield return a;
            yield return b;

            while (true)
            {
                var current = a + b;
                
                a = b;
                b = current;

                yield return current;
            }
        }

        public static IEnumerable<int> Generate(int countOfNumbers)
        {
            var a = 0;
            var b = 1;

            for (var i = 0; i < countOfNumbers; i++)
            {
                var current = a;

                a = b;
                b += current;

                yield return current;
            }
        }
    }
}
