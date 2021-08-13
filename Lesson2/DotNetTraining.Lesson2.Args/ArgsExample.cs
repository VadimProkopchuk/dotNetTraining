using System.Linq;

namespace DotNetTraining.Lesson2.Args
{
    public class ArgsExample
    {
        public static string OptionalArgs(int a, int b = 2, int c = 3)
        {
            return $"a: {a}, b: {b}, c: {c}";
        }


        public static void Sum(int a, int b)
        {
            b += a;
        }

        public static void SumRef(int a, ref int b)
        {
            b += a;
        }

        public static void SumIn(int a, in int b)
        {
            // b += a;
        }

        public static void SumOut(int a, int b, out int c)
        {
            c = a + b;
        }

        public static long SumParams(params int[] args)
        {
            return args.Sum();
        }
    }
}
