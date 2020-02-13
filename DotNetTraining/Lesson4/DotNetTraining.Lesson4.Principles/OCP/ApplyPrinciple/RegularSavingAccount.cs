namespace DotNetTraining.Lesson4.Principles.OCP.ApplyPrinciple
{
    public class RegularSavingAccount : IAccount
    {
        public decimal Balance { get; set; } = 0;
        public decimal CalcInterest()
        {
            var interest = (Balance * 4m) / 100m;

            if (Balance < 1000m) interest -= (Balance * 2m) / 100m;
            if (Balance < 50000m) interest += (Balance * 4m) / 100m;

            return interest;
        }
    }
}
