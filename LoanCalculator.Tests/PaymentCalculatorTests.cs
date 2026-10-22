
using LoanCalculator.Core;

namespace LoanCalculator.Tests
{
    public class PaymentCalculatorTests
    {
        [Fact]
        public void Growth_TwoMonthsAtTwoPercent_ReturnsCompoundValue()
        {
            //Arrange
            decimal monthlyRate = 0.02m;
            int months = 0;

            //Act
            decimal growth = PaymentCalculator.Growth(monthlyRate, months);

            //Assert
            Assert.Equal(1m, growth);
        }

        [Fact]
        public void Calculate_TwelveMonthsAtTwoPercent_ReturnsCompoundValue()
        {
            //Arrange
            decimal monthlyRate = 0.02m;
            int months = 12;
            decimal loanAmount = 120000m;

            //Act
            decimal payment = PaymentCalculator.Calculate(loanAmount, monthlyRate, months);

            //Assert
            Assert.Equal(11347.15m, payment);
        }
        [Fact]
        public void Calculate_TwelveMonthsAtZeroPercent_ReturnsCompoundValue()
        {
            //Arrange
            decimal monthlyRate = 0m;
            int months = 12;
            decimal loanAmount = 120000m;

            //Act
            decimal payment = PaymentCalculator.Calculate(loanAmount, monthlyRate, months);

            //Assert
            Assert.Equal(10000, payment);
        }
        [Fact]
        public void Calculate_OneMonthAtTwoPercent_ReturnsCompoundValue()
        {
            //Arrange
            decimal monthlyRate = 0.02m;
            int months = 1;
            decimal loanAmount = 100m;

            //Act
            decimal payment = PaymentCalculator.Calculate(loanAmount, monthlyRate, months);

            //Assert
            Assert.Equal(102m, payment);
        }
    }
}
