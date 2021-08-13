using System;

namespace DotNetTraining.Lesson2.Partial
{
    public partial class Bootstrap
    {
        partial void LoadSecondModule() => Console.WriteLine("Second module");
    }
}
