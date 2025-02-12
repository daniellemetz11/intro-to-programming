

using Banking.Domain;

namespace Banking.Tests.Accounts;
public class MakingWithdrawals
{
    [Theory]
    [InlineData(3.23)]
    [InlineData(5000.01)]

    public void MakingWithdrawalsDecreasesTheBalance(decimal amount)
    {
        var account = new Account();
        var openingBalance = account.GetBalance();
        var amountToWithdraw = 42.23M;


        account.Withdraw(amountToWithdraw);

        Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());
    }
}
