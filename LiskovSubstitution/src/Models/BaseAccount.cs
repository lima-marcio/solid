public abstract class BaseAccount : IDepositable, IReadableAccount
{
  protected decimal Balance;

  protected BaseAccount(decimal initialBalance)
  {
    Balance = initialBalance;
  }

  public void Deposit(decimal amount)
  {
    if (amount <= 0)
    {
      throw new ArgumentException("Deposit amount must be positive.", nameof(amount));
    }
    Balance += amount;
  }

  public decimal GetBalance() => Balance;
}