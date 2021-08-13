using System;

namespace DotNetTraining.Lesson2.Enums
{
    [Flags]
    public enum Colors
    {
        White = 1,
        Black = 2,
        Green = 4,
        All = White | Black | Green,
    }
}
