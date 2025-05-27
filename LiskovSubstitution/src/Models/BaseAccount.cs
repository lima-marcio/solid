public class BaseAccount : IAccount
{
  protected decimal Balance;

  public BaseAccount(decimal initialBalance)
  {
    Balance = initialBalance;
  }

  public void Deposit(decimal amount)
  {
    if (amount <= 0)
    {
      throw new ArgumentException("Deposit amount must be positive.", nameof(amount));
    }
  }

  public decimal GetBalance()
  {
    return Balance;
  }

  public virtual void Withdraw(decimal amount)
  {

    if (amount <= 0)
    {
      throw new ArgumentException("Withdrawal amount must be positive.", nameof(amount));
    }
    Balance -= amount;
    if (Balance < 0)
    {
      throw new InvalidOperationException("Insufficient funds for withdrawal.");
    }
  }
}