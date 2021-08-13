using System;

namespace DotNetTraining.Lesson1.BitwiseOperators
{
    public class BitwiseOperatorsExample
    {
        public void PrintBitwiseOperatorsExample()
        {
            var a = 60;
            var b = 13;
            var c = 0;

            c = a & b;
            Console.WriteLine(c);

            c = a | b;
            Console.WriteLine(c);

            c = a ^ b;
            Console.WriteLine(c);

            c = ~a;
            Console.WriteLine(c);

            c = a << 2;
            Console.WriteLine(c);

            c = a >> 2;
            Console.WriteLine(c);
        }
    }
}