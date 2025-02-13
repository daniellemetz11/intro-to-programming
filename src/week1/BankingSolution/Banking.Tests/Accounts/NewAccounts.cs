

using Banking.Domain;
using Banking.Tests.TestDoubles;
using NSubstitute;

namespace Banking.Tests.Accounts;
public class NewAccounts
{
  [Fact]
  public void BalanceIsCorrect()
  {
    var correctOpeningBalance = 5000M;
    // "Write the Code You Wish You Had" - More Corey Haines Wisdom

    //these were written before bonus calculator was needed, so just give it something dumb
    var myAccount = new Account(new Substitute.For<ICalculateBonusesForDepositsOnAccounts>());
    var yourAccount = new Account(new DummyBonusCalculator());

    var myBalance = myAccount.GetBalance();
    decimal yourBalance = yourAccount.GetBalance();

    Assert.Equal(correctOpeningBalance, myBalance);
    Assert.Equal(correctOpeningBalance, yourBalance);


  }
}
