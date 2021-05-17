using BankingDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankingTests
{
    public class GoldAccountDeposits
    {
        [Fact]
        public void GoldAccountsGetABonusOnDepositsAfterEOB()
        {
            var account = new GoldAccount();
            var openingBalance = account.GetBalance();
            var amountToDeposit = 100M;

            account.Deposit(amountToDeposit);

            Assert.Equal(
                openingBalance + amountToDeposit + 5, account.GetBalance());

        }

        [Fact]
        public void GoldAccountsGetABonusOnDepositsBeforeEOB()
        {
            var account = new GoldAccount();
            var openingBalance = account.GetBalance();
            var amountToDeposit = 100M;

            account.Deposit(amountToDeposit);

            Assert.Equal(
                openingBalance + amountToDeposit + 7, account.GetBalance());

        }
    }
}
