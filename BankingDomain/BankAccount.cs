using System;

namespace BankingDomain
{
    public class BankAccount
    {
        private decimal _balance = 5000;
        private ICalculateBonuses _bonusCalculator;

        public BankAccount(ICalculateBonuses bonusCalculator)
        {
            _bonusCalculator = bonusCalculator;
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public virtual void Deposit(decimal amountToDeposit)
        {
            // Write the code you wish you had. 
            decimal amountOfBonus = _bonusCalculator.CalculateTheBonusFor(amountToDeposit, _balance);
            _balance += amountToDeposit  + amountOfBonus;
        }

        public void Withdraw(decimal amountToWithdraw)
        {
            if(amountToWithdraw > _balance)
            {
                throw new OverdraftException();
            }
            _balance -= amountToWithdraw;
        }
    }
}