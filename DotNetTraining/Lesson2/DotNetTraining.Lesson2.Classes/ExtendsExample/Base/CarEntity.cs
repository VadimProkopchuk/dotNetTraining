using System;

namespace DotNetTraining.Lesson2.Classes.ExtendsExample.Base
{
    public class CarEntity : BaseUniqueEntity
    {
        public CarEntity() : base(nameof(CarEntity))
        {
            IsRed = new Random().Next(1, 3) == 2;
        }

        public bool IsRed { get; }
    }
}
