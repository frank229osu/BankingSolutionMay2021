using BankingDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankingTests
{
    public class NewBankAccountTests
    {
        [Fact]
        public void NewAccountsHaveAppropriateBalance()
        {
            // Given
            BankAccount account = new BankAccount(null,null);
            decimal expectedOpeningBalance = 5000M;
            // When
            decimal actualBalance = account.GetBalance();

            // Then
            Assert.Equal(expectedOpeningBalance, actualBalance);
        }
    }
}
