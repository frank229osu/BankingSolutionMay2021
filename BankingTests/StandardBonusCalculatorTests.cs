using BankingDomain;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankingTests
{
    public class StandardBonusCalculatorTests
    {
        // 	- If the deposit is made before EOB, then they get 7% added to the their deposit otherwise, they get 5%

        [Fact]
        public void DepositsMadeBeforeEOBGetSevenPercent()
        {
            var clock = new Mock<ISystemTime>();
            clock.Setup(c => c.GetCurrent()).Returns(new DateTime(1969, 4, 20, 16, 59, 59));

            ICalculateBonuses calculator = new StandardBonusCalculator(clock.Object);

            decimal bonus = calculator.CalculateTheBonusFor(100, 7000);

            Assert.Equal(7M, bonus);
        }

        [Fact]
        public void DepositsMadeBeforeEOBGetFivePercent()
        {
            var clock = new Mock<ISystemTime>();
            clock.Setup(c => c.GetCurrent()).Returns(new DateTime(1969, 4, 20, 17, 00, 00));
            ICalculateBonuses calculator = new StandardBonusCalculator(clock.Object);

            decimal bonus = calculator.CalculateTheBonusFor(100, 7000);

            Assert.Equal(5M, bonus);
        }

    }
}
