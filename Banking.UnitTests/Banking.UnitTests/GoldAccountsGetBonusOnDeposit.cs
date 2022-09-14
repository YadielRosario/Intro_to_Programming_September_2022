
using Banking.Domain;

namespace Banking.UnitTests;
public class GoldAccountsGetBonusOnDeposit
{
    [Fact]
    public void BonuAppliedOnDeposits()
    {
        var account = new GoldAccount();
        var openingBalance = account GetBalance();
        var amountToDeposit = 100M;

        account.Deposit(amountToDeposit);

        Assert.Equal(openingBalance + amountToDeposit + 10M, account.GetBalance());
    }
}
