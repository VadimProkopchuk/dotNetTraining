using System;

namespace DotNetTraining.Lesson1.AssignmentOperators
{
    public class AssignmentOperatorsExample
    {
        public void PrintAssignmentOperatorsExample()
        {
            var a = 20;
            int c;

            c = a;
            Console.WriteLine(c);

            c += a;
            Console.WriteLine(c);

            c -= a;
            Console.WriteLine(c);

            c *= a;
            Console.WriteLine(c);

            c /= a;
            Console.WriteLine(c);

            c = 100;
            c %= a;
            Console.WriteLine(c);

            c <<= 2;
            Console.WriteLine(c);

            c >>= 2;
            Console.WriteLine(c);

            c &= 2;
            Console.WriteLine(c);

            c ^= 2;
            Console.WriteLine(c);

            c |= 2;
            Console.WriteLine(c);
        }
    }
}