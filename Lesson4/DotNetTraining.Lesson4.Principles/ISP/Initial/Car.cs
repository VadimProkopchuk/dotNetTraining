using System;

namespace DotNetTraining.Lesson4.Principles.ISP.Initial
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            //actions to drive a car
            Console.WriteLine("Driving a car");
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
}
