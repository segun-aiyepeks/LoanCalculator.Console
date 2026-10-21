using LoanCalculator.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanCalculator.Tests
{
    public class InterestCalculatorTests
    {
        [Fact]
        public void Calculate_HalfKoboTie_RoundsUp()
        {
            //Arange
            decimal balance = 100.25m;
            decimal rate = 0.02m;

            //Act
            decimal interest = InterestCalculator.Calculate(balance, rate);

            //Assert
            Assert.Equal(2.01m, interest);
        }

        [Fact]
        public void Calculate_WholeKoboResult_ReturnsExactInterest()
        {
            //Arrange
            decimal balance = 120000m;
            decimal rate = 0.02m;

            //Act
            decimal interest = InterestCalculator.Calculate(balance, rate);

            //Assert
            Assert.Equal(2400, interest);
        }

        [Fact]
        public void Calculate_ThirdDecimalPresent_RoundsToKobo()
        {
            //Arrange
            decimal balance = 111052.85m;
            decimal rate = 0.02m;

            //Act
            decimal interest = InterestCalculator.Calculate(balance, rate);

            //Assert
            Assert.Equal(2221.06m, interest);
        }
    }
}
