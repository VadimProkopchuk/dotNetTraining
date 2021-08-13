using System.Linq;

namespace DotNetTraining.Lesson4.Principles.LSP
{
    public class SumCalculator : Calculator
    {
        public SumCalculator(int[] numbers)
            : base(numbers)
        {
        }

        public override int Calculate() => _numbers.Sum();
    }
}
