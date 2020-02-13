using System;

namespace DotNetTraining.Lesson2.Methods
{
    public static class DateExtensionsExample
    {
        public static string ToExampleFormat(this DateTime dateTime)
        {
            return $"{dateTime.Month} {dateTime.Day}, {dateTime.Year} (Ticks: {dateTime.Ticks})";
        }
    }
}
