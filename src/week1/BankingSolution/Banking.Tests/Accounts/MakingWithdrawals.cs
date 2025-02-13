﻿
using Banking.Domain;

namespace Banking.Tests.Accounts;
public class MakingWithdrawals
{

    [Theory]
    [InlineData(42.23)]
    [InlineData(3.23)]


    public void MakingWithdrawalsDecreasesTheBalance(decimal amountToWithdraw)
    {
        var account = new Account();
        var openingBalance = account.GetBalance();


        account.Withdraw(amountToWithdraw);

        Assert.Equal(openingBalance - amountToWithdraw,
            account.GetBalance());
    }

    [Fact]
    public void CanWithdrawFullBalance()
    {
        var account = new Account();

        account.Withdraw(account.GetBalance());

        Assert.Equal(0, account.GetBalance());
    }

    [Fact]
    public void WhenOverdraftBalanceIsNotReducedNotAllowed()
    {

        var account = new Account();
        var openingBalance = account.GetBalance();
        var amountThatRepresentsMoreThanTheCurrentBalance = openingBalance + .01M;

        try
        {
            account.Withdraw(amountThatRepresentsMoreThanTheCurrentBalance);
        }
        catch (AccountTransactionException)
        {
            // cool cool. swalling this...
        }

        Assert.Equal(openingBalance, account.GetBalance());
    }

    [Fact]
    public void WhenOverdraftMethodThrows()
    {
        var account = new Account();
        var openingBalance = account.GetBalance();
        var amountThatRepresentsMoreThanTheCurrentBalance = openingBalance + .01M;
        //var exceptionThrow = false;
        //try
        //{
        //    account.Withdraw(amountThatRepresentsMoreThanTheCurrentBalance);
        //}
        //catch (AccountOverdraftException) {
        //    // this is what we want!
        //    exceptionThrow = true;
        //}
        //    Assert.True(exceptionThrow);

        Assert.Throws<AccountOverdraftException>(() => account.Withdraw(amountThatRepresentsMoreThanTheCurrentBalance));

    }

    [Fact]
    public void CannotMakeWithdrawalWithNegativeNumbers()
    {

        var account = new Account();
        Assert.Throws<AccountTransactionException>(() => account.Withdraw(-3));
    }
}