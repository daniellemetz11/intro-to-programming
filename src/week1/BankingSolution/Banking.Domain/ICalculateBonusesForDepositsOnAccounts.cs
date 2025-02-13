namespace Banking.Domain;

public interface ICalculateBonusesForDepositsOnAccounts
{


  public interface ICalculateDepositBonusesForAccounts
  {
    decimal CalculateBonusForDeposit(decimal balance, decimal depositAmount);
  }
}
