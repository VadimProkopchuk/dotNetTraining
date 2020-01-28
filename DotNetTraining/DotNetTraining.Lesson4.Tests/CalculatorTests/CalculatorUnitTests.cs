using System;
using DotNetTraining.Lesson4.Calculator;
using NUnit.Framework;

namespace DotNetTraining.Lesson4.Tests.CalculatorTests
{
    [TestFixture]
    public class CalculatorUnitTests
    {
        [Test]
        public void Add_Input3And4_7Should()
        {
            var actual = SimpleCalculator.Add(3, 4);
            var expected = 7;
            Assert.AreEqual(expected, actual, double.Epsilon, "Three plus four is equal to seven.");
        }

        [Test]
        public void Sqrt_InputNegativeValue_ExceptionShould()
        {
            var random = new Random();
            var inputValue = random.Next(int.MinValue, -1) / 100d;

            Assert.Throws<ArgumentException>(() => SimpleCalculator.Sqrt(inputValue));
        }

        [Test]
        public void Sqrt_Input25_Return5()
        {
            var actual = SimpleCalculator.Sqrt(25);
            var expected = 5;

            Assert.AreEqual(expected, actual, double.Epsilon, "Sqrt of 25 is equal to 5.");
        }

        [TestCase(4)]
        [TestCase(100)]
        [TestCase(16)]
        public void IsEven_InputEvenValues_ReturnTrue(int value)
        {
            var actual = SimpleCalculator.IsEven(value);
            Assert.IsTrue(actual, $"{value} should be is even.");
        }

        [TestCase(1)]
        [TestCase(3)]
        [TestCase(101)]
        public void IsEven_InputOddValues_ReturnFalse(int value)
        {
            var actual = SimpleCalculator.IsEven(value);
            Assert.IsFalse(actual, $"{value} should be not is even.");
        }

        [Test]
        public void IsEven_InputZero_ReturnFalse()
        {
            var actual = SimpleCalculator.IsEven(0);
            Assert.IsFalse(actual, $"Zero should be not is even.");
        }

        [TestCase(3)]
        [TestCase(101)]
        [TestCase(15)]
        public void IsOdd_InputOddValues_ReturnTrue(int value)
        {
            var actual = SimpleCalculator.IsOdd(value);
            Assert.IsTrue(actual, $"{value} should be is odd.");
        }

        [TestCase(2)]
        [TestCase(4)]
        [TestCase(24)]
        public void IsOdd_InputEvenValues_ReturnFalse(int value)
        {
            var actual = SimpleCalculator.IsOdd(value);
            Assert.IsFalse(actual, $"{value} should be not is odd.");
        }

        [Test]
        public void IsOdd_InputZero_ReturnFalse()
        {
            var actual = SimpleCalculator.IsOdd(0);
            Assert.IsFalse(actual, $"Zero should be not is odd.");
        }
    }
}
