using BankingDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankingTests
{
    public class MakingWithdrawals
    {
        [Fact]
        public void MakingWithdrawalsDecreasesTheBalance()
        {
            var bankAcount = new BankAccount(null);
            var openingBalance = bankAcount.GetBalance();
            var amountToWithdraw = 100M;


            bankAcount.Withdraw(amountToWithdraw);

            Assert.Equal(openingBalance - amountToWithdraw, bankAcount.GetBalance());
        }


    }
}
