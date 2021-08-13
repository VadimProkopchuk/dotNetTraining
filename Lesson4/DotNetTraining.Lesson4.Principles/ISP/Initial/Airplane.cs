using System;

namespace DotNetTraining.Lesson4.Principles.ISP.Initial
{
    public class Airplane : IVehicle
    {
        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            //actions to fly a plane
            Console.WriteLine("Flying a plane");
        }
    }
}
