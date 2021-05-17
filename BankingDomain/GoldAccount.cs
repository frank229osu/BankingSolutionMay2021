using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingDomain
{
    public class GoldAccount : BankAccount
    {
        public override void Deposit(decimal amountToDeposit)
        {
            decimal bonusRate = DateTime.Now.Hour >= 17 ? 1.05M : 1.07M;
            base.Deposit(amountToDeposit * bonusRate);
        }
    }
}
