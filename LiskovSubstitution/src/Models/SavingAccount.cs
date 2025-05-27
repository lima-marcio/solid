public class SavingAccount : BaseAccount, IWithdrawable
{
  public SavingAccount(decimal initialBalance) : base(initialBalance) { }
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


