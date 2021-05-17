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
    public class MakingDeposits
    {

        [Fact]
        public void MakingDepositsIncreasesBalance()
        {
            var account = new BankAccount(new Mock<ICalculateBonuses>().Object);
            var openingBalance = account.GetBalance();
            var amountToDeposit = 100M;


            account.Deposit(amountToDeposit);

            Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());

        }
    }

    public class DummyBonusCalculator : ICalculateBonuses
    {
        public decimal CalculateTheBonusFor(decimal amountToDeposit, decimal balance)
        {
            return 0;
        }
    }
}
