
using Banking.Domain;

namespace Banking.UnitTests;
public class AccountWithdrawals
{
    [Fact]
    public void WithdrawingMoneyDecreasesBalance()
    {
        var account = new BankAccount();
        var openinBalance = account.GetBalance();
        var amountToWithdraw = 10M;

        account.Withdraw(amountToWithdraw);

        Assert.Equal(openinBalance - amountToWithdraw, account.GetBalance());   
    }

    [Fact]
    public void UsersCanWithdrawFullBalance()
    {
        var account = new BankAccount();

        account.Withdraw(account.GetBalance());
        
        Assert.Equal(0, account.GetBalance());  
    }

    

    [Fact]
    public void OverdraftDoesNotDecreaseBalance()
    {
        var account = new BankAccount();
        var openinBalance = account.GetBalance();
        var amountToWithdraw = openinBalance + .01M;

        account.Withdraw(amountToWithdraw);

        Assert.Equal(openinBalance, account.GetBalance());
    }
}
