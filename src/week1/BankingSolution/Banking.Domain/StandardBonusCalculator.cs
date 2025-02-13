
using static Banking.Domain.ICalculateBonusesForDepositsOnAccounts;

namespace Banking.Domain;

public class StandardBonusCalculator : ICalculateDepositBonusesForAccounts
{


  public decimal CalculateBonusForDeposit(decimal balance, decimal depositAmount)
  {
    return balance >= 5000 ? depositAmount * .10M : 0;
  }

  public decimal CalculateBonusForDeposits(decimal balance, decimal depositAmount)
  {
    throw new NotImplementedException();
  }
}

