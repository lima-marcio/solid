public class SavingAccount : IAccount
{
  private decimal _balance;

  public SavingAccount(decimal initialBalance, decimal interestRate)
  {
    _balance = initialBalance;
  }

  public void Deposit(decimal amount)
  {
    _balance += amount;
  }

  public void Withdraw(decimal amount)
  {
    if (amount > _balance)
    {
      throw new InvalidOperationException("Insufficient funds for withdrawal.");
    }
    _balance -= amount;
  }

  public decimal GetBalance()
  {
    return _balance;
  }
}