using System;

namespace BankingDomain
{
    public class BankAccount
    {
        public BankAccount()
        {
        }

        public decimal GetBalance()
        {
            return 5000; // "Sliming" a value.
        }

        public void Deposit(decimal amountToDeposit)
        {
           
        }
    }
}