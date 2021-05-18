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
    public class BankAccountWithdrawalNotifiesTheFed
    {
        [Fact]
        public void TheFedIsNotified()
        {
            var fedMock = new Mock<INotifyTheFeds>();
            var account = new BankAccount(null,fedMock.Object);


            account.Withdraw(42);

            // Assert
            fedMock.Verify(m => m.NarcOn(42));
        }
    }
}
