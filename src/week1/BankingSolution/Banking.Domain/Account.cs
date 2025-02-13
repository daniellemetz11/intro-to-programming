

namespace Banking.Domain;


public class Account
{
    private decimal _currentBalance = 5000;
    public void Deposit(decimal amountToDeposit)
    {

        CheckTransactionAmount(amountToDeposit);

        if (amountToDeposit < 0)
        {
            throw new AccountNegativeTransactionAmountException();
        }
        _currentBalance += amountToDeposit;

    }

    public decimal GetBalance()
    {
        // "Slime it"
        return _currentBalance;
    }

    public void Withdraw(decimal amountToWithdraw)
    {
        CheckTransactionAmount(amountToWithdraw);

        if (_currentBalance >= amountToWithdraw)
        {
            _currentBalance -= amountToWithdraw;
        }
        else
        {
            throw new AccountOverdraftException();
        }

    }




    //dont test private methods, they only support public, which you should already have tests for 
    private static void CheckTransactionAmount(decimal amount)
    {
        if(amount < 0)
        {
            throw new AccountNegativeTransactionAmountException();
        }
    }
}
