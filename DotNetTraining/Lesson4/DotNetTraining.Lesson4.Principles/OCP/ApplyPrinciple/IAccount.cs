namespace DotNetTraining.Lesson4.Principles.OCP.ApplyPrinciple
{
    public interface IAccount
    {
        decimal Balance { get; set; }
        decimal CalcInterest();
    }
}
