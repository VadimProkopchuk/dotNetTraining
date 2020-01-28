using System;

namespace DotNetTraining.Lesson4.Principles.SRP
{
    public class CarGarageStationUtility : IGarageUtility
    {
        public void OpenGate() => throw new NotImplementedException();

        public void CloseGate() => throw new NotImplementedException();

        public bool IsOpen => throw new NotImplementedException();
    }
}
