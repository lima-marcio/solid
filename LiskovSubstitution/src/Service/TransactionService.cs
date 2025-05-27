public class TransactionService
{
  public void Withdraw(IWithdrawable account, decimal amount)
  {
    if (account == null)
    {
      throw new ArgumentNullException(nameof(account), "Account cannot be null.");
    }
    if (amount <= 0)
    {
      throw new ArgumentException("Withdrawal amount must be positive.", nameof(amount));
    }

    account.Withdraw(amount);
  }
}