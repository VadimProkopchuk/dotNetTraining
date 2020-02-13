namespace DotNetTraining.Lesson4.Principles.OCP.ApplyPrinciple
{
    public class SalarySavingAccount : IAccount
    {
        public decimal Balance { get; set; } = 0;
        public decimal CalcInterest()
        {
            var interest = (Balance * 5m) / 100m;
            return interest;
        }
    }
}
