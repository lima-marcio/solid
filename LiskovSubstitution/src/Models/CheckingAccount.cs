public class CheckingAccount : IAccount
{
  private decimal _balance;

  public CheckingAccount(decimal initialBalance)
  {
    _balance = initialBalance;
  }

  public void Deposit(decimal amount)
  {
    if (amount <= 0)
    {
      throw new ArgumentException("Deposit amount must be positive.");
    }
    _balance += amount;
  }

  public void Withdraw(decimal amount)
  {
    if (amount <= 0)
    {
      throw new ArgumentException("Withdrawal amount must be positive.");
    }
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