
namespace LoanCalculator.Core
{
    public class InterestCalculator
    {
        public static decimal Calculate(decimal balance, decimal monthlyRate)
        {
            decimal interest = balance * monthlyRate;
            return Math.Round(interest, 2, MidpointRounding.AwayFromZero);
        }
    }

}
