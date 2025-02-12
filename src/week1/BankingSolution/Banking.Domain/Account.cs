
namespace Banking.Domain;
public class Account
{
    private decimal _openingBalance = 5000;

    public void Withdraw(decimal amountToWithdrawal)
    {
        _openingBalance -= amountToWithdrawal;
    }
    public void Deposit(decimal amountToDeposit)
    {
        _openingBalance += amountToDeposit;
    }
    public decimal GetBalance()
    {
        // "Slime it"
        return _openingBalance;
    }
}