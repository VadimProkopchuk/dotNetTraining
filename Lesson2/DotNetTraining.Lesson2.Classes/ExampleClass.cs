using System;

namespace DotNetTraining.Lesson2.Classes
{
    public class ExampleClass
    {
        private readonly string _name;
        private readonly int _age;

        public ExampleClass(string name, int age)
        {
            ValidateCtorArgs(name, age);
            _name = name;
            _age = age;
            Name = name;
            Age = age;
        }

        public string Name { get; }

        public int Age { get; }

        public string Do(string str)
        {
            var line = str ?? _name;
            return $"{line}_123124";
        }

        public override string ToString()
        {
            return $"Name: {_name}, Age: {_age}.";
        }

        private void ValidateCtorArgs(string name, int age)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name), "Name is required");
            }

            if (age < 0)
            {
                throw new ArgumentNullException(nameof(age), "Age should be positive.");
            }
        }
    }
}
