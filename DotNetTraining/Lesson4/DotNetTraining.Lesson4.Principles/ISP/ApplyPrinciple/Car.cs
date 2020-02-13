using System;

namespace DotNetTraining.Lesson4.Principles.ISP.ApplyPrinciple
{
    public class Car : ICar
    {
        public void Drive()
        {
            //actions to drive a car
            Console.WriteLine("Driving a car");
        }
    }
}
