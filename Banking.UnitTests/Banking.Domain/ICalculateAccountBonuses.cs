
namespace Banking.Domain;

// Interfaces model functionality abstractly. Classes provide concrete code that implements interace.
public interface ICalculateAccountBonuses
{
    decimal GetBonusForDepositOnAccount(decimal balance, decimal amountToDeposit);
}
