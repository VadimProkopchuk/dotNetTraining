namespace DotNetTraining.Lesson4.Principles.SRP
{
    public interface IGarageUtility
    {
        void OpenGate();
        void CloseGate();
        bool IsOpen { get; }
    }
}
