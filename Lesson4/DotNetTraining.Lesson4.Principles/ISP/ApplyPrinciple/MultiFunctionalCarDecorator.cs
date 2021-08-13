namespace DotNetTraining.Lesson4.Principles.ISP.ApplyPrinciple
{
    public class MultiFunctionalCarDecorator : IMultiFunctionalVehicle
    {
        private readonly ICar _car;
        private readonly IAirplane _airplane;

        public MultiFunctionalCarDecorator(ICar car, IAirplane airplane)
        {
            _car = car;
            _airplane = airplane;
        }

        public void Drive()
        {
            _car.Drive();
        }

        public void Fly()
        {
            _airplane.Fly();
        }
    }
}
