using System;

namespace DotNetTraining.Lesson2.Classes
{
    public class ClassWithOperatorExample
    {
        public ClassWithOperatorExample(int number)
        {
            Number = number;
        }

        public int Number { get; }

        public int this[int index]
        {
            get => index + Number;
            set => throw new NotImplementedException();
        }

        public static ClassWithOperatorExample operator +(ClassWithOperatorExample a, int number)
        {
            return new ClassWithOperatorExample(a.Number + number);
        }

        public override string ToString()
        {
            return $"Number: {Number}";
        }
    }
}
