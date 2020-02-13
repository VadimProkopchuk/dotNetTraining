using System;

namespace DotNetTraining.Lesson2.Classes
{
    public class FinalizerExample
    {
        private static int _countOfInstances;
        private readonly int _instanceNumber;

        static FinalizerExample()
        {
            _countOfInstances = 0;
        }
        
        public FinalizerExample()
        {
            _instanceNumber = ++_countOfInstances;

            Console.WriteLine($"Object with number {_instanceNumber} was created.");
        }

        ~FinalizerExample()
        {
            Console.WriteLine($"Object with number {_instanceNumber} was destroyed.");
        }
    }
}
