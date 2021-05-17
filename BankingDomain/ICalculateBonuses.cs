namespace BankingDomain
{
    public interface ICalculateBonuses
    {
        decimal CalculateTheBonusFor(decimal amountToDeposit, decimal balance);
    }
}