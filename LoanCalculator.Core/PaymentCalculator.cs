
namespace LoanCalculator.Core
{
    public class PaymentCalculator
    {
        public static decimal Growth(decimal monthlyRate, int months)
        {
            decimal result = 1m;
            for (int i = 0; i < months; i++)
            {
                result = result * (1 + monthlyRate);
            }

            return result;
        }
        public static decimal Calculate(decimal loanAmount, decimal monthlyRate, int months)
        {
            decimal payment;

            if (monthlyRate ==  0)
            {
                return loanAmount / months;
            } 
            else
            {
                decimal growth = Growth(monthlyRate, months);
                payment = loanAmount * monthlyRate * growth / (growth - 1);
            }

            return Math.Round(payment, 2, MidpointRounding.AwayFromZero);
        }
    }
}
