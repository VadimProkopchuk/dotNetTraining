using System;

namespace DotNetTraining.Lesson4.Principles.ISP.ApplyPrinciple
{
    public class Airplane : IAirplane
    {
        public void Fly()
        {
            //actions to fly a plane
            Console.WriteLine("Flying a plane");
        }
    }
}
