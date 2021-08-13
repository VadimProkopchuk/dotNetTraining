using System;

namespace DotNetTraining.Lesson1.ArithmeticOperators
{
    public class ArithmeticOperatorsExample
    {
        public void PrintArithmeticOperatorsExample()
        {
            var a = 10;
            var b = 20;
            var c = 0;

            c = a + b;
            Console.WriteLine(c);

            c = a - b;
            Console.WriteLine(c);

            c = a * b;
            Console.WriteLine(c);

            c = b / a;
            Console.WriteLine(c);

            c = b % a;
            Console.WriteLine(c);

            c = a++;
            Console.WriteLine(c);

            c = a--;
            Console.WriteLine(c);
        }
    }
}