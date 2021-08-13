namespace DotNetTraining.Lesson2.Methods
{
    public static class StaticExample
    {
        public static int Max(int a, int b, int c)
        {
            return Max(a, Max(b, c));
        }

        public static int Max(int a, int b)
        {
            if (a > b)
            {
                return a;
            }

            return b;
        }

        public static int Min(int a, int b, int c) => Min(a, Min(b, c));

        public static int Min(int a, int b) => a < b ? a : b;
    }
}
