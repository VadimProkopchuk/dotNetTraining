using System.Linq;

namespace DotNetTraining.Lesson4.Principles.LSP
{
    public class EvenNumbersSumCalculator : Calculator
    {
        public EvenNumbersSumCalculator(int[] numbers)
            : base(numbers)
        {
        }

        public override int Calculate() => _numbers.Where(x => x % 2 == 0).Sum();
    }
}
