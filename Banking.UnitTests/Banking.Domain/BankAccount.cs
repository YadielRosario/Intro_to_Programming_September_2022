namespace Banking.Domain;

public enum AccountLoyaltyLevel { Standard, Gold}
public class BankAccount
{
    private decimal _balance = 5000M;
    public AccountLoyaltyLevel AccountType { get; set; } = AccountLoyaltyLevel.Standard;
    public BankAccount()
    {
    }

    public void Deposit(decimal amountToDeposit)
    {
        decimal bonus = 0;
        if(AccountType == AccountLoyaltyLevel.Gold)
        {
            bonus = amountToDeposit * .10M;
        }
        _balance += amountToDeposit + bonus;
    }

    public decimal GetBalance()
    {
        return _balance;
    }

    public void Withdraw(decimal amountToWithdraw)
    {
        if (amountToWithdraw <= _balance)
        {
            _balance -= amountToWithdraw; 
        }
        else
        {
            throw new OverdraftException();
        }
        
    }
}