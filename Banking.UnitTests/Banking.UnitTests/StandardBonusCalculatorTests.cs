
using Banking.Domain;

namespace Banking.UnitTests;
public class StandardBonusCalculatorTests
{
    [Fact]
    public void AccountsThatMeetCriteriaGetBonus()
    {
        ICalculateAccountBonuses calculator = new StandardBonusCalculator();

        var bonus = calculator.GetBonusForDepositOnAccount(5000, 100);

        Assert.Equal(10M, bonus);
    }

    public void AccountsThatDontMeetCriteriaDoNotGetBonus()
    {
        ICalculateAccountBonuses calculator = new StandardBonusCalculator();

        var bonus = calculator.GetBonusForDepositOnAccount(4999.99M, 100);

        Assert.Equal(0, bonus);
    }
}
