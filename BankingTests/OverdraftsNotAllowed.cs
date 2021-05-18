using BankingDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankingTests
{
    public class OverdraftsNotAllowed
    {
        private BankAccount _account;
        private decimal _openingBalance;

        public OverdraftsNotAllowed()
        {
            _account = new BankAccount(null,null);
            _openingBalance = _account.GetBalance();
        }


        [Fact]
        public void BalanceIsNotDecreasedOnOverdraft()
        {
            try
            {
                _account.Withdraw(_openingBalance + 1);
            }
            catch (OverdraftException)
            {

                /// ignore it...
            }
            finally
            {
                Assert.Equal(_openingBalance, _account.GetBalance());
            }
        }

        [Fact]
        public void OverdraftThrowsException()
        {
            Assert.Throws<OverdraftException>(() => _account.Withdraw(_openingBalance + 1));
        }
    }
}
