namespace DotNetTraining.Lesson2.Args
{
    internal class ArgsContextExample
    {
        private readonly int _a;
        private readonly int _b;

        public ArgsContextExample(int a, int b)
        {
            _a = a;
            _b = b;
        }

        public int Sum(int a, int b)
        {
            var sum = 0;

            for (var i = 0; i < 5; i++)
            {
                var c = (this._a + a) * b;
                sum += c - this._b;
            }

            return sum + _a + _b;
        }
    }
}
