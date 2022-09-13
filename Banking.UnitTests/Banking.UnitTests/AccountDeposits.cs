
using Banking.Domain;

namespace Banking.UnitTests;
public class AccountDeposits
{
    [Fact]
    public void MakeADepositIncreasesTheBalance()
    {
        //Given
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        var amountToDeposit = 10.15M; //M changes the variable from a double to a decimal
        //When
        account.Deposit(amountToDeposit);
        //Then
        Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());
    }
}
