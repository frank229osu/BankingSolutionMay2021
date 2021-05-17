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
    public class BankAccountDepositsUseBonusCalculator
    {

        [Fact]
        public void TheAmountReturnedFromTheBonusCalculatorIsAddedToTheBalance()
        {
            // Given 
            var stubbedAccount = new Mock<ICalculateBonuses>();
           
            var account = new BankAccount(stubbedAccount.Object);
            var openingBalance = account.GetBalance();
            var amountToDeposit = 100M;
            stubbedAccount.Setup(b => 
                b.CalculateTheBonusFor(amountToDeposit, openingBalance)).Returns(42);
            

            // When??
            account.Deposit(amountToDeposit);

            // Then
            Assert.Equal(amountToDeposit + openingBalance + 42, account.GetBalance());

        }
    }

    public class StubbedBonusCalcualtor : ICalculateBonuses
    {
        public decimal CalculateTheBonusFor(decimal amountToDeposit, decimal balance)
        {
            return amountToDeposit == 100M && balance == 5000 ? 42 : -42;
        }
    }
}
