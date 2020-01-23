using System;

namespace DotNetTraining.Lesson2.Tuple
{
    public class TupleExample
    {
        public (string name, int age) GetModifiedPerson(string name, int age)
        {
            return (name: name?.ToUpper(), age: Math.Abs(age));
        }
    }
}
