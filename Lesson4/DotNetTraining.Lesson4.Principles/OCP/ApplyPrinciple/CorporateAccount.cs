namespace DotNetTraining.Lesson4.Principles.OCP.ApplyPrinciple
{
    public class CorporateAccount : IAccount
    {
        public decimal Balance { get; set; } = 0;
        public decimal CalcInterest()
        {
            var interest = (Balance * 3m) / 100m;
            return interest;
        }
    }
}
