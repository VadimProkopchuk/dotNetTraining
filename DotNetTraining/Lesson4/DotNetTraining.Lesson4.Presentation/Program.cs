using System;
using DotNetTraining.Lesson4.Principles.LSP;

namespace DotNetTraining.Lesson4.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            RunLSPExample();
        }

        static void RunLSPExample()
        {
            var numbers = new[] { 5, 7, 9, 8, 1, 6, 4 };

            Calculator sum = new SumCalculator(numbers);
            Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");

            Console.WriteLine();

            Calculator evenSum = new EvenNumbersSumCalculator(numbers);
            Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}");
        }
    }
}
