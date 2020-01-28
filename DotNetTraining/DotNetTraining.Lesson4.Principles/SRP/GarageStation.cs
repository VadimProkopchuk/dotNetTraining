namespace DotNetTraining.Lesson4.Principles.SRP
{
    public class GarageStation
    {
        private readonly IGarageUtility _garageUtil;

        public GarageStation(IGarageUtility garageUtil)
        {
            _garageUtil = garageUtil;
        }
        
        public void OpenForService()
        {
            _garageUtil.OpenGate();
        }
        
        public void DoService()
        {
            if (_garageUtil.IsOpen)
            {
                // do service
            }
        }

        public void CloseGarage()
        {
            _garageUtil.CloseGate();
        }
    }
}
