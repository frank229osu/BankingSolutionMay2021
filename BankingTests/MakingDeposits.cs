using BankingDomain;
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
            var account = new BankAccount();
            var openingBalance = account.GetBalance();
            var amountToDeposit = 100M;


            account.Deposit(amountToDeposit);

            Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());

        }
    }
}
