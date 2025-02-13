
using Banking.Domain;
using Banking.Tests.TestDoubles;
using NSubstitute;

namespace Banking.Tests.GoldAccounts;
public class GetBonusOnDeposits
{

  [Fact]
  public void GetBonus()
  {

    var stubbedBonusCalculator = Substitute.For<ICalculateBonusesForDepositsOnAccounts>();
    // Given
    var account = new Account(new StubbedBonusCalculator());
    var openingBalance = account.GetBalance();
    var amountToDeposit = 100M;
    var expectedBonus = 20M;

    stubbedBonusCalculator.CalculateBonusForDeposit(
      openingBalance, amountToDeposit).Returns(expectedBonus);

    var expectedNewBalance = openingBalance + amountToDeposit + expectedBonus;

    // When
    account.Deposit(amountToDeposit);

    // Then
    Assert.Equal(expectedNewBalance, account.GetBalance());

  }
}


public class StubbedBonusCalculator: ICalculateBonusesForDepositsOnAccounts
{

  public decimal CalculateBonusForDeposit(decimal balance, decimal depositAmount)
  {
    if(balance == 5000 && depositAmount == 1000)
    {
      return 20;
    }
    else
    {
      return 0;
    }
  }
}
