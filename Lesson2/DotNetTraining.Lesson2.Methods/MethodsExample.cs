namespace DotNetTraining.Lesson2.Methods
{
    public class MethodsExample
    {
        public int Max(int a, int b, int c)
        {
            return Max(a, Max(b, c));
        }

        public int Max(int a, int b)
        {
            if (a > b)
            {
                return a;
            }

            return b;
        }

        public int Min(int a, int b, int c) => Min(a, Min(b, c));

        public int Min(int a, int b) => a < b ? a : b;
    }
}
