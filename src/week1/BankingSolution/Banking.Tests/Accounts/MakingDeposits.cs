﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.Domain;

namespace Banking.Tests.Accounts;
public class MakingDeposits
{
    [Fact]
    public void MakingADepositIncreasesBalance()
    {
        //given that i have an account
        var account = new Account();

        var openingBalance = account.GetBalance();

        var amountToDeposit = 100.10M;

        //when the depsoit
        account.Deposit(amountToDeposit);

        //then

        var newBalance = account.GetBalance();

        Assert.Equal(amountToDeposit + openingBalance, account.GetBalance());

    }
}
