namespace DotNetTraining.Lesson4.Principles.OCP.Initial
{
    public class Account
    {
        public decimal Interest { get; set; }
        public decimal Balance { get; set; }
        
        public decimal CalcInterest(string accType)
        {

            if (accType == "Regular") // savings
            {
                Interest = (Balance * 4) / 100;
                if (Balance < 1000) Interest -= (Balance * 2) / 100;
                if (Balance < 50000) Interest += (Balance * 4) / 100;
            }
            else if (accType == "Salary") // salary savings
            {
                Interest = (Balance * 5) / 100;
            }
            else if (accType == "Corporate") // Corporate
            {
                Interest = (Balance * 3) / 100;
            }

            return Interest;
        }
    }
}
