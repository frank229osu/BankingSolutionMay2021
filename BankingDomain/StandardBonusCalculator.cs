using System;

namespace BankingDomain
{
    public class StandardBonusCalculator : ICalculateBonuses
    {
        private readonly ISystemTime _systemTime;

        public StandardBonusCalculator(ISystemTime systemTime)
        {
            _systemTime = systemTime;
        }

        public decimal CalculateTheBonusFor(decimal amountToDeposit, decimal balance)
        {
            return _systemTime.GetCurrent().Hour >= 17 ? amountToDeposit * .05M : amountToDeposit * .07M;
        }
    }
}

/*
 * "The best way to work with untestable code is to kick it into a corner until it learns to play nice
 * - Jeremy D. Miller
 * 
 * 
 * "Make all variables explicit."
 * */